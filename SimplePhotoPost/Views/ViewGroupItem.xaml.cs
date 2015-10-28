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

        public ViewGroupItem(ModelGroupItem model, ViewSettings settings)
        {
            this.model = model;
            //model.title = "Новая группа";
            this.model.viewSettings = settings;
            InitializeComponent();
        }

        private void Delete(object sender, MouseButtonEventArgs e)
        {
            this.model.listbox.Items.Remove(this);
            this.model.listGroupItem.Remove(this.model);
        }

        private void OpenGroupSettings(object sender, MouseButtonEventArgs e)
        {
            this.model.viewSettings.viewGroupItem = this;
            ControllerGroupItem.SetSettingsView(model.viewSettings, model);

            //// Отображаем окно
            this.model.viewSettings.Show();
        }
    }
}
