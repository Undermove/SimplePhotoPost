using System.Collections.Generic;
using System.Windows.Controls;
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

        public ViewGroupItem(ViewSettings settings)
        {
            model.title = "Новая группа";
            model.settings = settings;
            InitializeComponent();
        }

        private void Delete(object sender, MouseButtonEventArgs e)
        {
            model.listbox.Items.Remove(this);
            model.listGroupItem.Remove(this.model);
        }

        private void OpenGroupSettings(object sender, MouseButtonEventArgs e)
        {
            //ControllerGroupItem.SetSettingsView(model, settings);

            //// Отображаем окно
            //this.settings.Show();
        }
    }
}
