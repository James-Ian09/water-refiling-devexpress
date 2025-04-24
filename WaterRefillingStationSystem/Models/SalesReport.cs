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
        private static int NumberCounter = 1;

        public int ID { get; set; }
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

        //Station
        public string Number { get; private set; }
        public string ItemName { get; set; }
        public int UnitPrice { get; set; }
        public int Quantity { get; set; }
        public int AvailableStock { get; set; }
        public string RentedItems { get; set; }
        public string OrderType { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime RentedDate { get; set; }
        public int TotalPrice { get; set; }

        public SalesReport(int iD, string firstName, string middleName, string lastName, string contactNumber, string address, int debt, string number, string itemName, int unitPrice, int quantity,
                           int availableStock, string rentedItems, string orderType, DateTime orderDate, DateTime rentedDate, int totalPrice)
        {
            ID = iD;
            FirstName = firstName;
            MiddleName = middleName;
            LastName = lastName;
            ContactNumber = contactNumber;
            Address = address;
            Debt = debt;
            Number = (NumberCounter++).ToString();
            ItemName = itemName;
            UnitPrice = unitPrice;
            Quantity = quantity;
            AvailableStock = availableStock;
            RentedItems = rentedItems;
            OrderType = orderType;
            OrderDate = orderDate;
            RentedDate = rentedDate;
            TotalPrice = totalPrice;
        }
    }
}
