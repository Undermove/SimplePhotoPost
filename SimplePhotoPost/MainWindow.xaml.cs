﻿using SimplePhotoPost.UI_Items;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Web;
using System.Windows;
using System.Windows.Input;
using Newtonsoft.Json;

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
        public Settings ui_Settings = new Settings();
        // Стартовый ID
        int item_id = 0;
        // Создаем список групп-объектов. Он нужен для доступа к этим объектам 
        List<UI_GroupItem> itemsList = new List<UI_GroupItem>();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Click_AddGroup(object sender, MouseButtonEventArgs e)
        {
            // Генерируем новый блок интерфейса и передаем ему ссылку на экземпляр класса окна настроек 
            UI_GroupItem ui_groupItem = new UI_GroupItem(ui_Settings);
            // Задаем ID для элемента списка
            ui_groupItem.id = item_id;
            // Передаем в него ссылку на тот listBox в котором он находится, это нужно для функции удаления
            ui_groupItem.listbox = listBox;
            ui_groupItem.itemsList = itemsList;
            
            // Вставляем в ListBox новый элемент UI_Group_Item
            listBox.Items.Insert(0, ui_groupItem);
            // Также добавим объект в список для доступа к нему в цикле foreach
            itemsList.Add(ui_groupItem);

            // Увеличим item_id для последующих элементов
            item_id += 1;
        }

        private void Click_Authorize(object sender, MouseButtonEventArgs e)
        {
            vk = vk.Authorize("wall,photos,groups,offline,messages");
            //Thickness brwsMargin = new Thickness(0, 0, 0, 0);
            //var browser = new WebBrowser() { Margin = brwsMargin };

            //Window window = new Window { Width = 800, Height = 600 };
            //window.Content = browser;

            //var authLink = String.Format("http://vk.com");
            //browser.Navigate(authLink);

            //window.ShowDialog();
        }

        private void SimplePhotoPost(object sender, MouseButtonEventArgs e)
        {
            /// Пока рановато, но уже скоро будет можно
            foreach (UI_GroupItem item in itemsList)
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
                System.Windows.MessageBox.Show("SSSS");
            }
        }

        private void Window_Closing(object sender, CancelEventArgs e)
        {
            string output = JsonConvert.SerializeObject(itemsList);
            MessageBox.Show(output);
        }

    }
}
