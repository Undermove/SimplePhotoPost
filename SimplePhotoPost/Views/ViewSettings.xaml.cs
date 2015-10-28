using System.Windows;
using System.Windows.Input;
using System.Windows.Forms;
using SimplePhotoPost.Classes;
using SimplePhotoPost.Controllers;
using SimplePhotoPost.Models;
using SimplePhotoPost.Properties;
using SimplePhotoPost.Views;

namespace SimplePhotoPost.Views
{
    /// <summary>
    /// Interaction logic for UI_GroupSettings.xaml
    /// </summary>
    public partial class ViewSettings : Window 
    {
        public ViewGroupItem viewGroupItem;
        public ModelGroupItem modelGroupItem;
        private FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
        
        public ViewSettings()
        {
            InitializeComponent();
        }

        private void SaveAndExit(object sender, MouseButtonEventArgs e)
        {
            ControllerSettings.SaveModel(this.modelGroupItem, this, this.viewGroupItem);
            ControllerGroupItem.ChangeTitle(this.modelGroupItem);
            //ControllerGroupItemmodelGroupItemhis.modelGroupItem);
            Hide();
        }
        
        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            ControllerSettings.SaveModel(this.modelGroupItem, this, this.viewGroupItem);

            ControllerGroupItem.ChangeTitle(this.modelGroupItem);
            //ControllerGroupItemmodelGroupItemhis.modelGroupItem);
            e.Cancel = true;
            Hide();
        }

        private void OpenFolder(object sender, MouseButtonEventArgs e)
        {
            folderBrowserDialog.ShowDialog();
            if (folderBrowserDialog.SelectedPath != "folderBrowserDialog1")
                this.Path.Text = folderBrowserDialog.SelectedPath;
        }
    }
}
