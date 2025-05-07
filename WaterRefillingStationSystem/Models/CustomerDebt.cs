using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaterRefillingStationSystem.Models
{
    public class CustomerDebt : SalesDetails
    {
        public string Name { get; set; } //Primary Key
        public string OrderType { get; set; }
        public string ItemName { get; set; }
        public int Quantity { get; set; }
        public int UnitPrice { get; set; }
        public string OrderDate { get; set; }
        public int Debt { get; set; }
    }
}
