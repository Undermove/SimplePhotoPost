using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimplePhotoPost.Models;
using SimplePhotoPost.Views;

namespace SimplePhotoPost.Controllers
{
    class ControllerSettings
    {
        /// <summary>
        /// Устанавливает в вид Settings значения свойств из модели GroupItem
        /// </summary>
        /// <param name="Model"> Модель GroupItem </param>
        /// <param name="View"> Вид Settings</param>
        public static void SetSettingsView(ModelGroupItem model, ViewSettings view)
        {
            // Связываем содержание объекта с отображением в настройках
            //view.Message.Text = model.message;
            //view.HashTags.Text = model.hashTags;
            //view.AlbumId.Text = model.albumId;
            //view.GroupId.Text = model.groupId;
            //view.Path.Text = model.path;
            //view.Title.Text = model.title;
        }
    }
}
