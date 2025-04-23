using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaterRefillingStationSystem.Models
{
    public class ItemNames : Customers
    {
        public string RoundGallon { get; set; }
        public string SlimGallonWithFaucet { get; set; }
        public string Dispenser { get; set; }

        public ItemNames(string iD, string firstName, string middleName, string lastName, string contactNumber, string address, int debt, string roundGallon, string slimGallonWithFaucet, string dispenser) : base(iD, firstName, middleName, lastName, contactNumber, address, debt)
        {
            RoundGallon = roundGallon;
            SlimGallonWithFaucet = slimGallonWithFaucet;
            Dispenser = dispenser;
        }
    }
}
