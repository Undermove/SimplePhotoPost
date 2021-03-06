﻿using System.Windows;
using System.Windows.Input;
using System.Windows.Forms;
using SimplePhotoPost.Classes;
using SimplePhotoPost.Controllers;
using SimplePhotoPost.Models;
using SimplePhotoPost.Properties;
using SimplePhotoPost.Views;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System;
using System.Windows.Media.Animation;
using System.Windows.Controls;

namespace SimplePhotoPost.Controllers
{
    public class ControllerGroupItem
    {
        /// <summary>
        /// Устанавливает в вид значения свойств из модели
        /// </summary>
        /// <param name="Model"> Модель </param>
        /// <param name="View"> Вид </param>
        public static void SetSettingsView(ViewSettings view, ModelGroupItem model)
        {          
            // Связываем содержание объекта с отображением в настройках
            view.modelGroupItem = model;
            view.Message.Text = model.message;
            view.HashTags.Text = model.hashTags;
            view.AlbumId.Text = model.albumId;
            view.GroupId.Text = model.groupId;
            view.Path.Text = model.path;
            view.Title1.Text = model.title;
            view.Color.SelectedColor = model.color;
        }

        public static void ChangeGroupItem(ModelGroupItem model)
        {
            model.viewGroupItem.Title.Text = model.title;

            SetStatusPicture(model);

            if (model.color != null)
            {
                SolidColorBrush brush = new SolidColorBrush(Color.FromArgb(model.color.Value.A, model.color.Value.R, model.color.Value.G, model.color.Value.B));
                model.viewGroupItem.GroupRect.Fill = brush;
            }
        }

        public static void SetStatusPicture(ModelGroupItem model)
        {
            switch (model.Status)
            {
                case ModelGroupItem.MessageStatus.Error:
                    model.viewGroupItem.StatusCheck.Visibility = Visibility.Hidden;
                    model.viewGroupItem.StatusCheck.IsChecked = false;
                    model.viewGroupItem.StatusImage.Visibility = Visibility.Visible;
                    model.viewGroupItem.StatusImage.Source = new BitmapImage(new Uri(@"pack://siteoforigin:,,,/Tiles/Exclamation.png"));
                    model.viewGroupItem.StatusImage.ToolTip = "Проверьте верно ли введены все значения?";
                    break;
                case ModelGroupItem.MessageStatus.InDelivery:
                    break;
                case ModelGroupItem.MessageStatus.InProgress:
                    model.viewGroupItem.StatusCheck.Visibility = Visibility.Hidden;
                    model.viewGroupItem.StatusImage.Visibility = Visibility.Visible;
                    model.viewGroupItem.StatusImage.Source = new BitmapImage(new Uri(@"pack://siteoforigin:,,,/Tiles/Sync.png"));
                    break;
                case ModelGroupItem.MessageStatus.MessageSent:
                    model.viewGroupItem.StatusCheck.Visibility = Visibility.Hidden;
                    model.viewGroupItem.StatusImage.Visibility = Visibility.Visible;
                    model.viewGroupItem.StatusImage.Source = new BitmapImage(new Uri(@"pack://siteoforigin:,,,/Tiles/Checked.png"));
                    break;
                case ModelGroupItem.MessageStatus.NotReady:
                    model.viewGroupItem.StatusCheck.Visibility = Visibility.Hidden;
                    model.viewGroupItem.StatusImage.Visibility = Visibility.Visible;
                    model.viewGroupItem.StatusImage.Source = new BitmapImage(new Uri(@"pack://siteoforigin:,,,/Tiles/Exclamation.png"));
                    model.viewGroupItem.StatusImage.ToolTip = "Не все поля заполнены";
                    break;
                case ModelGroupItem.MessageStatus.Ready:
                    model.viewGroupItem.StatusImage.Visibility = Visibility.Hidden;
                    model.viewGroupItem.StatusCheck.Visibility = Visibility.Visible;
                    break;
            } 
        }
    }
}
