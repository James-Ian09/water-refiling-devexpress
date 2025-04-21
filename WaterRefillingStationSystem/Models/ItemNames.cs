using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaterRefillingStationSystem.Models
{
    public class ItemNames
    {
        public string RoundGallon { get; set; }
        public string SlimGallonWithFaucet { get; set; }
        public string Dispenser { get; set; }

        public ItemNames(string roundGallon, string slimGallonWithFaucet, string dispenser) 
        {
            RoundGallon = roundGallon;
            SlimGallonWithFaucet = slimGallonWithFaucet;
            Dispenser = dispenser;
        }
    }
}
