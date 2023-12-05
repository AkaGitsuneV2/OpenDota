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
    public partial class FormItemsAbout : MetroFramework.Forms.MetroForm
    {
        public int hero_id;
        public string hero_name;

        public FormItemsAbout(int hero_id, string hero_name)
        {
            InitializeComponent();
            this.hero_id = hero_id;
            this.hero_name = hero_name;
        }

        private async void FormItemsAbout_Load(object sender, EventArgs e)
        {
            metroGrid1.ReadOnly = true;
            this.Text = "Предметы для персонажа " + hero_name;

            string response = await Meta.getResponse("https://api.opendota.com/api/scenarios/itemTimings");
            var items = JsonConvert.DeserializeObject<List<Items>>(response);

            if (items != null)
            {

                List<Items> list = new List<Items>();

                foreach (Items item in items)
                {
                    if (hero_id == Convert.ToInt32(item.hero_id))
                    {
                        list.Add(item);
                    }
                }

                for (int i = 0; i < list.Count; i++)
                {

                    metroGrid1.Rows.Add(1);
                    metroGrid1.Rows[i].Cells[0].Value = list[i].item;
                    metroGrid1.Rows[i].Cells[1].Value = list[i].games;
                    double wr = Math.Round(Convert.ToDouble(list[i].wins) / Convert.ToDouble(list[i].games),2);
                    metroGrid1.Rows[i].Cells[2].Value = wr;
                }
               
            }

            while (metroGrid1.Rows.Count <= 0) continue;

            metroProgressSpinner1.Dispose();
        }


    }

    public class Items
    {
        public string hero_id { get; set; }
        public string item { get; set; }
        //public string time { get; set; }
        public string games { get; set; }
        public string wins { get; set; }
    }
}
