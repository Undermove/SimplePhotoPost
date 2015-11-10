using Newtonsoft.Json;
using SimplePhotoPost.Classes;
using SimplePhotoPost.Controllers;
using SimplePhotoPost.Models;
using SimplePhotoPost.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Threading;
using System.Web;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using System.Xml.Serialization;

namespace SimplePhotoPost
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        // Создаем экземпляр класса вконтакте который содержит методы работы с ВК
        private Vk vk = new Vk();
        // Создаем экземпляр окна настроек 
        public ViewSettings viewSettings = new ViewSettings();
        // Стартовый ID
        int itemId = 0;
        // Создаем список групп-объектов. Он нужен для доступа к этим объектам 
        public List<ModelGroupItem> listGroupItem = new List<ModelGroupItem>();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Click_AddGroup(object sender, MouseButtonEventArgs e)
        {
            ModelGroupItem modelGroupItem = new ModelGroupItem(itemId, viewSettings, listBox, listGroupItem);
            ViewGroupItem viewGroupItem = new ViewGroupItem(modelGroupItem, viewSettings);
            modelGroupItem.viewGroupItem = viewGroupItem;
            ControllerGroupItem.SetStatusPicture(modelGroupItem);
            

            //modelGroupItem.Status = ModelGroupItem.MessageStatus.NotReady;

            listGroupItem.Add(modelGroupItem);
            listBox.Items.Insert(listBox.Items.Count-1, viewGroupItem);

            // Увеличим item_id для последующих элементов
            itemId++;
        }

        private void Click_Authorize(object sender, MouseButtonEventArgs e)
        {
            try
            {
                vk = vk.Authorize("wall,photos,groups,offline,messages");
                if (vk.isAuthorized)
                {
                    this.AuthStatus.Text = "Статус: Авторизация пройдена";
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.ToString());
            }
        }

        private void SimplePhotoPost(object sender, MouseButtonEventArgs e)
        {
         
                if (vk.isAuthorized)
                {
                    int sendCount = 0;
                    /// Пока рановато, но уже скоро будет можно
                    foreach (ModelGroupItem model in listGroupItem)
                    {
                        try
                        {
                            if (model.Status == ModelGroupItem.MessageStatus.InDelivery)
                            {
                                model.Status = ModelGroupItem.MessageStatus.InProgress;
                                ControllerGroupItem.SetStatusPicture(model);
                                
                                // Получаем список путей до каждой из фотграфий
                                string[] photos = Directory.GetFiles(model.path);
                                // передаем этот список в метод загрузки фоток в альбом
                                string[] photosId = vk.photoPost(model.groupId, model.albumId, photos);
                                // После этого формируем поле attachments
                                string attachments = "";
                                //...Здесь должен быть код
                                //
                                foreach (var photoId in photosId)
                                {
                                    attachments = attachments + String.Format("photo-{0}_{1}", model.groupId, photoId) + ",";
                                }
                                attachments = attachments + String.Format("album-{0}_{1}", model.groupId, model.albumId);
                                vk.wallPost(HttpUtility.UrlEncode(model.message + "\n" + model.hashTags), model.groupId, attachments);
                                model.message = "";
                                sendCount++;
                            }
                            //System.Windows.MessageBox.Show("SSSS");
                        }
                        catch (Exception exc)
                        {
                            MessageBox.Show(exc.ToString());
                            model.Status = ModelGroupItem.MessageStatus.Error;
                            ControllerGroupItem.SetStatusPicture(model);
                        }
                    }
                    MessageBox.Show(String.Format("Отправка завершена! Отправлено: {0} сообщений.", sendCount));
                }
                else
                {
                    MessageBox.Show("Авторизация не пройдена. Авторизуйтесь, чтобы продолжить.");
                }

        }

        private void Window_Closing(object sender, CancelEventArgs e)
        {
            ListGroupItems SaveList = new ListGroupItems();
            SaveList.listGroupItem = listGroupItem;

            using (FileStream Stream = new FileStream("userdata/Serialization.xml", FileMode.Create, FileAccess.ReadWrite, FileShare.ReadWrite))
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(ListGroupItems));
                xmlSerializer.Serialize(Stream, SaveList);
            }
            System.Diagnostics.Process.GetCurrentProcess().Kill(); // насильно завершаем процесс, если он не завершился самостоятельно
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            using (FileStream Stream = new FileStream("userdata/Serialization.xml", FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.ReadWrite))
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(ListGroupItems));
                ListGroupItems SaveList = (ListGroupItems)xmlSerializer.Deserialize(Stream);

                foreach (ModelGroupItem modelGroupItem in SaveList.listGroupItem)
                {
                    modelGroupItem.listbox = listBox;
                    modelGroupItem.listGroupItem = listGroupItem;

                    ViewGroupItem viewGroupItem = new ViewGroupItem(modelGroupItem, viewSettings);
                    modelGroupItem.viewGroupItem = viewGroupItem;
                    modelGroupItem.SetStatus();
                    // Проверяем заполненные поля и выставляем стату готовности к отправке
                    ControllerGroupItem.ChangeGroupItem(modelGroupItem);
                    
                    //viewGroupItem.SendStatus.Text = modelGroupItem.Status.ToString();

                    // Добавляем модель в список моделей и вид в lisBox 
                    listGroupItem.Add(modelGroupItem);
                    listBox.Items.Insert(listBox.Items.Count - 1, viewGroupItem);
                }
            }
        }
    }
}
