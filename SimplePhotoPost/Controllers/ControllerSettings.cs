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
            model.title = view.Title1.Text;
            model.message = view.Message.Text;
            model.hashTags = view.HashTags.Text;
            model.albumId = view.AlbumId.Text;
            model.groupId = view.GroupId.Text;
            model.path = view.Path.Text;
            model.color = view.Color.SelectedColor;
        }
    }
}
