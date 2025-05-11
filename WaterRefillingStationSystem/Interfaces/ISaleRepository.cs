using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaterRefillingStationSystem.Interfaces
{
    public interface ISaleRepository
    {
        void AddSale(string orderType, string itemName, int quantity, int unitPrice, int totalPrice, string orderDate);
        List<(string FirstName, string MiddleName, string LastName)> GetCustomerNames();
        int GetCustomerIdByName(string firstName, string lastName);
    }
}
