using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenDota
{
    internal class AboutCharacters : Characters
    {

        public string img { get; set; }
        public string base_health { get; set; }
        //public string base_health_regen { get; set; }
        public string base_mana { get; set; }
        //public string base_mana_regen { get; set; }
        public string base_armor { get; set; }
        //public string base_mr { get; set; }
        public string base_attack_min { get; set; }
        public string base_attack_max { get; set; }
        public string attack_range { get; set; }
        public string attack_rate { get; set; }
        //public string projectile_speed { get; set; }
        public string move_speed { get; set; }
        //public string day_vision { get; set; }
        //public string night_vision { get; set; }
        public string hero_id { get; set; }

        //https://docs.opendota.com/#tag/hero-stats/operation/get_hero_stats
    }
}
