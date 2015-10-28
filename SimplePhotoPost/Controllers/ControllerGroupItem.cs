using System.Windows;
using System.Windows.Input;
using System.Windows.Forms;
using SimplePhotoPost.Classes;
using SimplePhotoPost.Controllers;
using SimplePhotoPost.Models;
using SimplePhotoPost.Properties;
using SimplePhotoPost.Views;

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
        }

        public static void ChangeTitle(ModelGroupItem model)
        {
            model.viewGroupItem.Title.Text = model.title;
        }
    }
}
