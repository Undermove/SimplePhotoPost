using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Web;
using System.Windows;
using System.Windows.Input;
using Newtonsoft.Json;
using System.Xml.Serialization;
using SimplePhotoPost.Classes;
using SimplePhotoPost.Models;
using SimplePhotoPost.Views;
using System.Threading;

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
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.ToString());
            }
        }

        private void SimplePhotoPost(object sender, MouseButtonEventArgs e)
        {
            try
            {
                if (vk.isAuthorized)
                {
                    /// Пока рановато, но уже скоро будет можно
                    foreach (ModelGroupItem item in listGroupItem)
                    {
                        if (item.path != "")
                        {
                            // Получаем список путей до каждой из фотграфий
                            string[] photos = Directory.GetFiles(item.path);
                            // передаем этот список в метод загрузки фоток в альбом
                            string[] photosId = vk.photoPost(item.groupId, item.albumId, photos);
                            // После этого формируем поле attachments
                            string attachments = "";
                            //...Здесь должен быть код
                            //
                            foreach (var photoId in photosId)
                            {
                                attachments = attachments + String.Format("photo-{0}_{1}", item.groupId, photoId) + ",";
                            }
                            attachments = attachments + String.Format("album-{0}_{1}", item.groupId, item.albumId);
                            vk.wallPost(HttpUtility.UrlEncode(item.message + "\n" + item.hashTags), item.groupId, attachments);
                        }
                        //System.Windows.MessageBox.Show("SSSS");
                    }
                    MessageBox.Show("Posted");
                }
                else
                {
                    MessageBox.Show("Авторизация не пройдена. Авторизуйтесь, чтобы продолжить.");
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.ToString());
            }
        }

        private void Window_Closing(object sender, CancelEventArgs e)
        {
            ListGroupItems SaveList = new ListGroupItems();
            SaveList.listGroupItem = listGroupItem;

            using (FileStream Stream = new FileStream("Serialization.xml", FileMode.Create, FileAccess.ReadWrite, FileShare.ReadWrite))
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(ListGroupItems));
                xmlSerializer.Serialize(Stream, SaveList);
            }
            System.Diagnostics.Process.GetCurrentProcess().Kill(); // насильно завершаем процесс, если он не завершился самостоятельно
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            using (FileStream Stream = new FileStream("Serialization.xml", FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.ReadWrite))
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(ListGroupItems));
                ListGroupItems SaveList = (ListGroupItems)xmlSerializer.Deserialize(Stream);

                foreach (ModelGroupItem modelGroupItem in SaveList.listGroupItem)
                {
                    modelGroupItem.listbox = listBox;
                    modelGroupItem.listGroupItem = listGroupItem;

                    ViewGroupItem viewGroupItem = new ViewGroupItem(modelGroupItem, viewSettings);
                    modelGroupItem.viewGroupItem = viewGroupItem;
                    viewGroupItem.Title.Text = modelGroupItem.title;

                    listGroupItem.Add(modelGroupItem);
                    listBox.Items.Insert(listBox.Items.Count - 1, viewGroupItem);
                }
            }
        }

    }
}
