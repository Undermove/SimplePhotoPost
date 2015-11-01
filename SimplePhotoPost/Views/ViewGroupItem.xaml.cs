using System.Collections.Generic;
using System.Windows.Controls;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;
using SimplePhotoPost.Models;
using SimplePhotoPost.Controllers;

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
            //model.title = "Новая группа";
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
            ControllerGroupItem.SetSettingsView(Settings, model);

            //// Отображаем окно
            Settings.ShowDialog();
        }
    }
}
