using MetroFramework.Controls;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace OpenDota
{
    public static class Meta
    {
        public static List<IconCharacter> icons;

        public static async Task<string> getResponse(string url)
        {
            try
            {
                WebClient wp = new WebClient();
                Uri uri = new Uri(url);
                return await wp.DownloadStringTaskAsync(uri);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка полученния данных от сервера Open Dota API! Информация об ошибке: {ex.Message};{ex.Source};{ex.HelpLink}", "Ошибка", MessageBoxButton.OK);
                return null;
            }


        }

        public static async Task<Image> GetImage(string urlImage)
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    var image = await client.GetByteArrayAsync(urlImage);
                    using (MemoryStream ms = new MemoryStream(image))
                    {
                        return Image.FromStream(ms);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка полученния изображения от сервера Open Dota API! Информация об ошибке: {ex.Message};{ex.Source};{ex.HelpLink}", "Ошибка", MessageBoxButton.OK);
                return null;
            }
        }


    }
}
