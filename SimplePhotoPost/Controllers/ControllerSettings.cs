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
        public static void SaveModel(ModelGroupItem model, ViewSettings view, ViewGroupItem viewGroupItem)
        {
            // Связываем содержание объекта с отображением в настройках
            //view.Message.Text = model.message;
            //view.HashTags.Text = model.hashTags;
            //view.AlbumId.Text = model.albumId;
            //view.GroupId.Text = model.groupId;
            //view.Path.Text = model.path;
            //view.Title.Text = model.title;

            // Сохраняем свойства объекта переданные из окна натроек, при закрытии окна
            //model.viewGroupItem = viewGroupItem;
            model.title = view.Title1.Text;
            model.message = view.Message.Text;
            model.hashTags = view.HashTags.Text;
            model.albumId = view.AlbumId.Text;
            model.groupId = view.GroupId.Text;
            model.path = view.Path.Text;
        }
    }
}
