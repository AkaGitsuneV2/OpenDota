using MetroFramework.Controls;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OpenDota
{
    public partial class FormCharacters : MetroFramework.Forms.MetroForm
    {
        public FormCharacters()
        {
            InitializeComponent();
            this.StyleManager = metroStyleManager1;

        }

        private async void FormCharacters_Load(object sender, EventArgs e)
        {

            string response = await Meta.getResponse("https://api.opendota.com/api/heroes");
            metroGrid1.DataSource = JsonConvert.DeserializeObject<List<Characters>>(response);

            //var avatarList = SQL.getListData("select image_avatar from images;");

            if (metroGrid1.DataSource != null)
            {

                DataGridViewImageColumn imgColumn = new DataGridViewImageColumn();
                imgColumn.Name = "Аватар";
                metroGrid1.Columns.Insert(0, imgColumn);

                for (int i = 0; i < metroGrid1.Rows.Count; i++)
                {
                    metroGrid1.Rows[i].Cells["Аватар"].Value = SQL.getImageFromBinaryArray($"select image_avatar_binary from images where image_id = {i + 1}");
                }

                while (metroGrid1.Rows.Count <= 0) continue;

                metroProgressSpinner1.Dispose();

                metroGrid1.ReadOnly = true;
                metroGrid1.Columns["id"].Visible = true;
                metroGrid1.Columns["localized_name"].HeaderText = "Имя";
                metroGrid1.Columns["attack_type"].HeaderText = "Тип атаки";
            }
        }


        private void metroGrid1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex < 0) return;
            FormAboutCharacters formAboutCharacters = new FormAboutCharacters(e.RowIndex);
            formAboutCharacters.Show();
        }
    }
    public class IconCharacter
    {

        public string icon { get; set; }
    }
}
