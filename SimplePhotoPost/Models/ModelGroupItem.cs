﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xceed.Wpf.Toolkit;
using System.Windows.Input;
using System.Windows.Media;
using System.Threading.Tasks;
using SimplePhotoPost.Views;
using System.Windows.Controls;
using SimplePhotoPost.Classes;
using System.Xml.Serialization;

namespace SimplePhotoPost.Models
{
    [Serializable]
    public class ModelGroupItem
    {
        /// Поля необходимые для заполнения при создании
        // ID элемента 
        public int id { get; set; }

        [XmlIgnore]
        public ViewGroupItem viewGroupItem {get; set; }

        // Поля необходимые для удаления объекта
        // Cсылка на listbox в котором находится элемент
        [XmlIgnore]
        public ListBox listbox { get; set; }
        
        // Ссылка на список в котором находится модель
        [XmlIgnore]
        public List<ModelGroupItem> listGroupItem { get; set; }

        /// Поля необходимые для окна настроек
        public string title { get; set; }
        public string path { get ; set; }
        public string groupId { get; set; }
        public string albumId { get; set; }
        //[XmlIgnore]
        public string message { get; set; }
        public string hashTags { get; set; }
        [XmlIgnore]
        public MessageStatus Status {get; set; }
        public bool ckBoxDeletePhoto { get; set; }
        public System.Windows.Media.Color? color { get; set; }


        public enum MessageStatus
        {
            NotReady = 0,
            Ready = 1,
            InDelivery = 2,
            InProgress = 3,
            MessageSent = 4,
            Error = 5
        }

        public void SetStatus()
        {
            if ((path != "") && (path != "Выберите папку с фото") && (groupId != "") && (albumId != "") && (message != "") && (hashTags != "") &&
                (path != null) && (path != null) && (groupId != null) && (albumId != null) && (message != null) && (hashTags != null))
            {
                Status = MessageStatus.Ready;
            }
            else
            {
                Status = MessageStatus.NotReady;
            }
        }

        public void SetStatusInDelivery()
        {
            Status = MessageStatus.InDelivery;
        }

        public ModelGroupItem()
        { }

        public ModelGroupItem(int id, ViewSettings viewSettings, ListBox listbox, List<ModelGroupItem> listGroupItem)
        {
            this.id = id;
            this.listbox = listbox;
            this.listGroupItem = listGroupItem;
            this.Status = MessageStatus.NotReady;
        }
    }
}
