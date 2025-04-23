using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace WaterRefillingStationSystem.Models
{
    
    public class SalesReport
    {
        public string ID { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string FullName
        {
            get
            {
                return $"{FirstName} {MiddleName} {LastName}";
            }
        }
        public string ContactNumber { get; set; }
        public string Address { get; set; }
        public int Debt { get; set; }
        public string Number { get; private set; }
        public int Quantity { get; set; }
        public int UnitPrice { get; set; }
        public int AvailableStock { get; set; }
        public string RoundGallon { get; set; }
        public string SlimGallonWithFaucet { get; set; }
        public string Dispenser { get; set; }
        public string WalkIn { get; set; }
        public string ForDelivery { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime RentedDate { get; set; }
        public int TotalPrice { get; set; }

        public SalesReport(string iD, string firstName, string middleName, string lastName, string contactNumber, string address, int debt, string number, int quantity, int unitPrice, 
                           int availableStock, string roundGallon, string slimGallonWithFaucet, string dispenser, string walkIn, string forDelivery ,DateTime orderDate, DateTime rentedDate, int totalPrice)
        {
            ID = iD;
            FirstName = firstName;
            MiddleName = middleName;
            LastName = lastName;
            ContactNumber = contactNumber;
            Address = address;
            Debt = debt;
            Number = number;
            Quantity = quantity;
            UnitPrice = unitPrice;
            AvailableStock = availableStock;
            RoundGallon = roundGallon;
            SlimGallonWithFaucet = slimGallonWithFaucet;
            Dispenser = dispenser;
            WalkIn = walkIn;
            ForDelivery = forDelivery;
            OrderDate = orderDate;
            RentedDate = rentedDate;
            TotalPrice = totalPrice;
        }
    }
}
