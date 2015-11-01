using Newtonsoft.Json.Linq;
using System;
using System.Threading;
using System.Web;
using System.Windows;
using System.Windows.Controls;
using xNet;

namespace SimplePhotoPost.Classes
{
    class Vk
    {
        public string accessToken;
        public string expiresIn;
        public string userId;
        public bool isAuthorized = false;

        private const int appID = 5101865;

        public Vk Authorize(string scope)
        {
            var vk = new Vk();
            var thread = new Thread(() =>
            {
                var window = new Window { Width = 800, Height = 600 };
                
                Thickness brwsMargin = new Thickness(0, 0, 0, 0);
                var browser = new WebBrowser() { Margin = brwsMargin };
                window.Content = browser;

                var authLink = String.Format("https://oauth.vk.com/authorize?client_id={0}&display=popup&redirect_uri=https://oauth.vk.com/blank.html&scope={1}&response_type=token&v=5.37", appID, scope);
                browser.Navigate(authLink);

                browser.Navigated += (sender, e) =>
                {
                    if (e.Uri.GetLeftPart(UriPartial.Query) == "https://oauth.vk.com/blank.html")
                    {
                        var url = new Uri(e.Uri.AbsoluteUri.Replace('#', '?'));
                        var parameters = HttpUtility.ParseQueryString(url.Query);
                        var accessToken = parameters.Get("access_token");
                        var expiresIn = parameters.Get("expires_in");
                        var userId = parameters.Get("user_id");
                        var isAuthorized = true;
                        vk = new Vk(accessToken, expiresIn, userId, isAuthorized);
                        window.Close();
                    }
                    else if (e.Uri.GetLeftPart(UriPartial.Query) == "https://oauth.vk.com/")
                    {
                        throw new Exception("Ошибка: Проверьте подключен ли Интеренет и пройдена ли авторизация.");
                    }
                };
                window.ShowDialog();
            });
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
            thread.Join();
            return vk;
        }
 

        public Vk(string accessToken, string expiresIn, string userId, bool isAuthorized)
        {
            this.accessToken = accessToken;
            this.expiresIn = expiresIn;
            this.userId = userId;
            this.isAuthorized = isAuthorized;
        }
        public Vk()
        {
            this.accessToken = "";
            this.expiresIn = "";
            this.userId = "";
        }

        private string vkMethod (string methodName, string parameters)
        {
            using (var req = new xNet.HttpRequest())
            {
                return req.Get(String.Format("https://api.vk.com/method/{0}?{1}&access_token={2}", methodName, parameters, this.accessToken)).ToString();
            }
        }

        public void wallPost (string messageText)
        {
            vkMethod("wall.post", String.Format("owner_id={0}&message={1}", userId, messageText));
        }

        public void wallPost(string messageText, string attachments)
        {
            MessageBox.Show(vkMethod("wall.post", String.Format("owner_id={0}&message={1}&attachments={2}", userId, messageText, attachments)));
        }

        public void wallPost(string messageText, string groupId, string attachments)
        {
            vkMethod("wall.post", String.Format("owner_id=-{0}&message={1}&attachments={2}", groupId, messageText, attachments));
        }

        // Постит фотгафии в ответ возвращая массив айдишников последних добавленных фотографий
        public string[] photoPost(string groupId, string albumId, string[] photos)
        {
            // Получаем ответ от сервера в формате JSON group_id - должен быть положительным, то есть минус не нужен!!!
            string response = vkMethod("photos.getUploadServer", String.Format("group_id={0}&album_id={1}", groupId, albumId));

            // Получаем ссылку на сервер, которую можно использовать для загрузки фотки путем обработки JSON запроса
            var json = JObject.Parse(response);
            var strUrl = json["response"]["upload_url"] as JValue;
            Uri upploadUrl = new Uri(strUrl.ToString());

            // составляем POST запрос при помощи которого отправляем фотографии на сервер
            string[] photoWallArray = photos;
            using (var req = new xNet.HttpRequest())
            {
                if (photos.Length != 0)
                {
                    for (int photoNumber = 0; photoNumber < photos.Length; photoNumber++)
                    {
                        req.AddFile("file1", photos[photoNumber]);
                        string getUpload = req.Post(upploadUrl).ToString();

                        json = JObject.Parse(getUpload);
                        var server = json["server"] as JValue;
                        var photosList = json["photos_list"] as JValue;
                        var hash = json["hash"] as JValue;

                        response = vkMethod("photos.save", String.Format("group_id={0}&album_id={1}&server={2}&photos_list={3}&hash={4}&", groupId, albumId, server, photosList, hash));

                        json = JObject.Parse(response);
                        var photoId = (string)json["response"][0]["pid"];

                        photoWallArray[photoNumber] = photoId; 
                    }
                }
            }
            return photoWallArray;
        }




    }
}
