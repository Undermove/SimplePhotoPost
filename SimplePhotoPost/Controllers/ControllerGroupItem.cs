using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimplePhotoPost.Models;
using SimplePhotoPost.Views;
using SimplePhotoPost;
using SimplePhotoPost.Controllers;
using SimplePhotoPost.Properties;

namespace SimplePhotoPost.Controllers
{
    public class ControllerGroupItem
    {
        /// <summary>
        /// Устанавливает в вид значения свойств из модели
        /// </summary>
        /// <param name="Model"> Модель </param>
        /// <param name="View"> Вид </param>
        public static void SetSettingsView(ModelGroupItem model, ViewSettings view)
        {          
            // Связываем содержание объекта с отображением в настройках
            view.Message.Text = model.message;
            view.HashTags.Text = model.hashTags;
            view.AlbumId.Text = model.albumId;
            view.GroupId.Text = model.groupId;
            view.Path.Text = model.path;
            view.Title.Text = model.title;
        }
    }
}
