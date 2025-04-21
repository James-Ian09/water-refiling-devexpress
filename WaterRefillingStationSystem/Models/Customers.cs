using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaterRefillingStationSystem.Models
{
    public class Customers
    {
        public string ID { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string ContactNumber { get; set; }
        public string Address { get; set; }
        public int Debt { get; set; }

        public Customers(string iD, string firstName, string middleName, string lastName, string contactNumber, string address, int debt)
        {
            ID = iD;
            FirstName = firstName;
            MiddleName = middleName;
            LastName = lastName;
            ContactNumber = contactNumber;
            Address = address;
            Debt = debt;
        }
    }
}
