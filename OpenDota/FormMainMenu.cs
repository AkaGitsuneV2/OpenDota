using K4os.Compression.LZ4.Streams.Frames;
using MetroFramework.Components;
using MetroFramework.Controls;
using MySql.Data.MySqlClient;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OpenDota
{
    public partial class FormMainMenu : MetroFramework.Forms.MetroForm
    {
        public FormMainMenu()
        {

            InitializeComponent();

        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            this.StyleManager = metroStyleManager1;

            string responseAbout = await Meta.getResponse("https://api.opendota.com/api/heroStats");
            Meta.icons = JsonConvert.DeserializeObject<List<IconCharacter>>(responseAbout);
        }

        private void metroButtonPlayers_Click(object sender, EventArgs e)
        {
            FormPlayers formPlayers = new FormPlayers();
            formPlayers.Show();
        }

        private void metroButtonCharacters_Click(object sender, EventArgs e)
        {
            FormCharacters formCharacters = new FormCharacters();
            formCharacters.Show();
        }

        private void metroButtonItems_Click(object sender, EventArgs e)
        {
            FormItems formItems = new FormItems();
            formItems.Show();

        }

        public async Task DownloadIcons()//Так качал иконки, на данный момент не используется
        {
            string responseAbout = await Meta.getResponse("https://api.opendota.com/api/heroStats");
            var iconList = JsonConvert.DeserializeObject<List<IconCharacter>>(responseAbout);
            for (int i = 0; i < iconList.Count; i++)
            {
                Image img = await Meta.GetImage("https://api.opendota.com" + iconList[i].icon);
                string file = iconList[i].icon.Substring(iconList[i].icon.IndexOf("icons/") + 6);
                file = file.Replace("?", "");
                Debug.WriteLine(file);
                img.Save(file);

            }
        }

        public byte[] imageToByte(Image img)// Преобразование картинки в массив byte[]
        {
            using (var ms = new MemoryStream())
            {

                img.Save(ms, ImageFormat.Png);
                return ms.ToArray();
            }
        }

        public void byteArrayToDataBase(string HeroOrAvatar)// Запись в БД изображения в виде массива byte[]
        {
            var image_path = SQL.getListData($"select image_{HeroOrAvatar} from images;");

            for (int i = 0; i < image_path.Count; i++)
            {
                var img = Image.FromFile(image_path[i]);
                byte[] data = imageToByte(img);

                using (MySqlConnection MySqlConnection = new MySqlConnection("Server=localhost;Database=dota;User Id=root;Password=;"))
                {
                    MySqlConnection.Open();
                    using (MySqlCommand cmd = new MySqlCommand($"UPDATE images SET image_{HeroOrAvatar}_binary = @image WHERE image_{HeroOrAvatar} = '{image_path[i]}'", MySqlConnection))
                    {

                        cmd.Parameters.Add("@image", MySqlDbType.LongBlob).Value = data;
                        cmd.ExecuteNonQuery();
                        

                    }
                }
            }
        }

      
    }

}





