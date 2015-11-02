using System.Windows;
using System.Windows.Input;
using System.Windows.Forms;
using System.Windows.Media;
using Xceed.Wpf.Toolkit;
using SimplePhotoPost.Classes;
using SimplePhotoPost.Controllers;
using SimplePhotoPost.Models;
using SimplePhotoPost.Properties;
using SimplePhotoPost.Views;
using SimplePhotoPost;

namespace SimplePhotoPost.Views
{
    /// <summary>
    /// Interaction logic for UI_GroupSettings.xaml
    /// </summary>
    public partial class ViewSettings : Window 
    {
        bool colorCall = false;
        public ViewGroupItem viewGroupItem;
        public ModelGroupItem modelGroupItem;
        private FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
                      
        public ViewSettings()
        {
            InitializeComponent();
            colorCall = true;
        }

        private void SaveAndExit(object sender, MouseButtonEventArgs e)
        {
            ControllerSettings.SaveModel(this.modelGroupItem, this, this.viewGroupItem);
            ControllerGroupItem.ChangeGroupItem(this.modelGroupItem);
            this.Close();
        }
        
        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            var result = System.Windows.MessageBox.Show("Сохранить изменения?", "Yes/No", MessageBoxButton.YesNo);

            if (result == MessageBoxResult.Yes)
            {
                ControllerSettings.SaveModel(this.modelGroupItem, this, this.viewGroupItem);
                ControllerGroupItem.ChangeGroupItem(this.modelGroupItem);
            }
        }

        private void OpenFolder(object sender, MouseButtonEventArgs e)
        {
            folderBrowserDialog.ShowDialog();
            if (folderBrowserDialog.SelectedPath != "folderBrowserDialog1")
                this.Path.Text = folderBrowserDialog.SelectedPath;
        }

        private void Color_SelectedColorChanged(object sender, RoutedPropertyChangedEventArgs<Color?> e)
        {
            if (colorCall)
            {
                SolidColorBrush brush = new SolidColorBrush(System.Windows.Media.Color.FromArgb(Color.SelectedColor.Value.A, Color.SelectedColor.Value.R, Color.SelectedColor.Value.G, Color.SelectedColor.Value.B));
                this.Rectangle1.Fill = brush;
                this.Rectangle2.Fill = brush;
                this.Title1.Background = brush;
                this.Path.Background = brush;
            }
            colorCall = true;
        }

    }
}
