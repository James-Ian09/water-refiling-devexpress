using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace WaterRefillingStationSystem.Models
{

    public class SalesDetails
    {
        public int SalesID { get; set; } // Primary Key
        public string ItemName { get; set; }
        public int UnitPrice { get; set; }
        public int Quantity { get; set; }
        public int TotalPrice { get; set; }
        public int Debt { get; set; } // Represents Total Debt if applicable
        public string OrderType { get; set; }
        public DateTime OrderDate { get; set; }
        public int AvailableStock { get; set; }
        public string RentedItems { get; set; }
        public DateTime RentedDate { get; set; }
    }

}
