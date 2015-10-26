using System.Windows;
using System.Windows.Input;
using System.Windows.Forms;

namespace SimplePhotoPost.UI_Items
{
    /// <summary>
    /// Interaction logic for UI_GroupSettings.xaml
    /// </summary>
    public partial class Settings : Window 
    {
        public UI_GroupItem item;
        private FolderBrowserDialog folderBrowserDialog1 = new FolderBrowserDialog();
        
        public Settings()
        {
            InitializeComponent();
        }

        public Settings(UI_GroupItem item)
        {
            this.item = item;
            InitializeComponent();
        }

        // Функция сохранения объекта
        private void Save()
        {
            // Сохраняем свойства объекта переданные из окна натроек, при закрытии окна
            this.item.title = this.Title.Text;
            this.item.message = this.Message.Text;
            this.item.hashTags = this.HashTags.Text;
            this.item.albumId = this.AlbumId.Text;
            this.item.groupId = this.GroupId.Text;
            this.item.path = this.Path.Text;

            // Связываем представление предмета в главном окне со свойством объекта
            this.item.Title.Text = this.Title.Text;
        }

        private void SaveAndExit(object sender, MouseButtonEventArgs e)
        {
            Save();
            Hide();
        }
        
        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Save();
            e.Cancel = true;
            Hide();
        }

        private void OpenFolder(object sender, MouseButtonEventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
            if (folderBrowserDialog1.SelectedPath != "folderBrowserDialog1")
                this.Path.Text = folderBrowserDialog1.SelectedPath;
        }
    }
}
