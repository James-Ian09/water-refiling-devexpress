using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WaterRefillingStationSystem.Models;

namespace WaterRefillingStationSystem.Interfaces
{
    public interface ISaleRepository
    {
        void AddSale(string orderType, string itemName, int quantity, int unitPrice, int totalPrice, DateTime orderDate);
        List<(string FirstName, string MiddleName, string LastName)> GetCustomerNames();
        int GetCustomerIdByName(string firstName, string lastName);
    }
}
