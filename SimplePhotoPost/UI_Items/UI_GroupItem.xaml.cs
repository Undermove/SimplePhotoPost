using System.Collections.Generic;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using SimplePhotoPost.UI_Items;

namespace SimplePhotoPost
{
    /// <summary>
    /// Interaction logic for Item.xaml
    /// </summary>
    public partial class UI_GroupItem : UserControl
    {
        
        public ListBox listbox;

        public Settings settings;

        public List<UI_GroupItem> itemsList;

        public int id;
        public string title = "";
        public string path = "";
        public string groupId = "";
        public string albumId = "";
        public string message = "";
        public string hashTags = "";
        public bool ckBoxDeletePhoto = true;
        public Color color = Colors.DarkBlue;
        
        public UI_GroupItem()
        {
            InitializeComponent();
        }

        public UI_GroupItem(Settings settings)
        {
            this.title = "Новая группа";
            this.settings = settings;
            InitializeComponent();
        }

        private void Delete(object sender, MouseButtonEventArgs e)
        {
            this.listbox.Items.Remove(this);
            this.itemsList.Remove(this);

        }

        private void OpenGroupSettings(object sender, MouseButtonEventArgs e)
        {
            // Передаем ссылку на объект в меню настроек
            this.settings.item = this;
            // Связываем содержание объекта с отображением в настройках
            this.settings.Message.Text = this.message;
            this.settings.HashTags.Text = this.hashTags;
            this.settings.AlbumId.Text = this.albumId;
            this.settings.GroupId.Text = this.groupId;
            this.settings.Path.Text = this.path;
            this.settings.Title.Text = this.title;

            // Отображаем окно
            this.settings.Show();
        }
    }
}
