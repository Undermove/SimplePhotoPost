using System.Collections.Generic;
using System.Windows.Controls;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;
using SimplePhotoPost.Models;
using SimplePhotoPost.Controllers;
using System.Windows.Media.Animation;
using System;

namespace SimplePhotoPost.Views
{
    /// <summary>
    /// Interaction logic for Item.xaml
    /// </summary>
    public partial class ViewGroupItem : UserControl
    {
        public ModelGroupItem model;
        
        public ViewGroupItem()
        {
            InitializeComponent();
        }

        public ViewGroupItem(ModelGroupItem model, ViewSettings settings)
        {
            this.model = model;
            InitializeComponent();
        }

        private void Delete(object sender, MouseButtonEventArgs e)
        {
            string message = string.Format("Удалить {0}?", this.model.title);
            var result = MessageBox.Show(message, "Yes/No", MessageBoxButton.YesNo);
          
            if (result == MessageBoxResult.Yes)
            {
                this.model.listbox.Items.Remove(this);
                this.model.listGroupItem.Remove(this.model);
            }
        }

        private void OpenGroupSettings(object sender, MouseButtonEventArgs e)
        {
            var Settings = new ViewSettings();
            Settings.viewGroupItem = this;
            if ((model.path == null) || (model.path == ""))
            {
                model.path = "Выберите папку с фото";
            }
            ControllerGroupItem.SetSettingsView(Settings, model);

            //// Отображаем окно
            Settings.ShowDialog();
        }

        private void StatusCheck_Checked(object sender, RoutedEventArgs e)
        {
            model.Status = ModelGroupItem.MessageStatus.InDelivery;
        }

        private void StatusCheck_Unchecked(object sender, RoutedEventArgs e)
        {
            model.SetStatus();
        }

        private void UserControl_MouseEnter(object sender, MouseEventArgs e)
        {
        }

        private void UserControl_MouseLeave(object sender, MouseEventArgs e)
        {
        }

        private void GroupRect_MouseEnter(object sender, MouseEventArgs e)
        {

        }
    }
}
