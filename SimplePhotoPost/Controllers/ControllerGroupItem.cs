using System.Windows;
using System.Windows.Input;
using System.Windows.Forms;
using SimplePhotoPost.Classes;
using SimplePhotoPost.Controllers;
using SimplePhotoPost.Models;
using SimplePhotoPost.Properties;
using SimplePhotoPost.Views;
using System.Windows.Media;

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
            if (model.color != null)
            {
                SolidColorBrush brush = new SolidColorBrush(Color.FromArgb(model.color.Value.A, model.color.Value.R, model.color.Value.G, model.color.Value.B));
                model.viewGroupItem.GroupRect.Fill = brush;
            }

        }
    }
}
