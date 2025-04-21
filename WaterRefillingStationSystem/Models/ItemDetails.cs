using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaterRefillingStationSystem.Models
{
    public class ItemDetails
    {
        public int Quantity { get; set; }
        public int UnitPrice { get; set; }
        public int AvailableStock { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime RentedDate { get; set; }
        public int TotalPrice { get; set; }

        public ItemDetails(int quantity, int unitPrice, int availableStock, DateTime orderDate, DateTime rentedDate, int totalPrice) 
        {
            Quantity = quantity;
            UnitPrice = unitPrice;
            AvailableStock = availableStock;
            OrderDate = orderDate;
            RentedDate = rentedDate;
            TotalPrice = totalPrice;
        }
    }
}
