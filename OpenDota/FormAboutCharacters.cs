using MetroFramework.Controls;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace OpenDota
{
    public partial class FormAboutCharacters : MetroFramework.Forms.MetroForm
    {
        public int hero_id;

        public FormAboutCharacters(int id)
        {

            InitializeComponent();
            this.hero_id = id;
            this.StyleManager = metroStyleManager1;

        }

        private async void FormAboutCharacters_Load(object sender, EventArgs e)
        {

            string response = await Meta.getResponse("https://api.opendota.com/api/heroStats");
            var pers = JsonConvert.DeserializeObject<List<AboutCharacters>>(response);

            //https://api.opendota.com/apps/dota2/images/dota_react/heroes/icons/antimage.png? icons

            if (pers != null)
            {
                
                pictureBox1.Image = SQL.getImageFromBinaryArray($"select image_hero_binary from images where image_id = {hero_id+1}");

                metroLabelName.Text = "Имя: " + pers[hero_id].localized_name;
                metroLabelHealth.Text = "HP: " + pers[hero_id].base_health;
                metroLabelMana.Text = "Мана: " + pers[hero_id].base_mana;
                metroLabelArmor.Text = "Броня: " + pers[hero_id].base_armor;
                metroLabelAttackMin.Text = "Урон min: " + pers[hero_id].base_attack_min;
                metroLabelAttackMax.Text = "Урон max: " + pers[hero_id].base_attack_max;
                metroLabelMove.Text = "Скорость передвижения: " + pers[hero_id].move_speed;
                metroLabelAttackRange.Text = "Дальность атаки: " + pers[hero_id].attack_range;
                metroLabelHeroId.Text = "ID: " + pers[hero_id].hero_id;

                metroLabelDay.Text = "Дневная видимость: " + pers[hero_id].base_attack_max;
                metroLabelNight.Text = "Ночная видимость: " + pers[hero_id].move_speed;
                metroLabelPicks.Text = "Turbo пик: " + pers[hero_id].attack_range;
                metroLabelWins.Text = "Turbo побед: " + pers[hero_id].hero_id;
            }

            while (metroLabelHeroId.Text.Length <= 0) continue;

            metroProgressSpinner1.Dispose();
        }
    }
}
