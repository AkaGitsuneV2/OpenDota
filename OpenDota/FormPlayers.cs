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
    public partial class FormPlayers : MetroFramework.Forms.MetroForm
    {
        public FormPlayers()
        {
            InitializeComponent();
            this.StyleManager = metroStyleManager1;
        }


        private async void FormPlayers_Load(object sender, EventArgs e)
        {
            string playersUrl = "https://api.opendota.com/api/proPlayers";

            string response = await Meta.getResponse(playersUrl);

            metroGrid1.DataSource = JsonConvert.DeserializeObject<List<Player>>(response);

            if (metroGrid1.DataSource != null)
            {
                metroGrid1.ReadOnly = true;
                metroGrid1.Columns["personaname"].HeaderText = "Внутреигровой никнейм";
                metroGrid1.Columns["loccountrycode"].HeaderText = "Страна";
                metroGrid1.Columns["name"].HeaderText = "Никнейм в команде";
                metroGrid1.Columns["team_name"].HeaderText = "Название команды";
                metroGrid1.Columns["team_tag"].HeaderText = "Сокр.название команды";
            }

            while (metroGrid1.Rows.Count <= 0) continue;

            metroProgressSpinner1.Enabled = false;
            metroProgressSpinner1.Dispose();

        }
    }
}
