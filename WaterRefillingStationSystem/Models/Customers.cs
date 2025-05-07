using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaterRefillingStationSystem.Models
{
    public class Customers : SalesDetails
    {
        public int CustomerID { get; set; } // Primary Key
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string ContactNumber { get; set; }
        public string Address { get; set; }
    }
}
