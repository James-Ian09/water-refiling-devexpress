using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WaterRefillingStationSystem.Models;

namespace WaterRefillingStationSystem.Interfaces
{
    public interface ICustomerRepository
    {
        List<Customers> GetAllCustomers();
        Customers GetCustomerById(int customerId);
        void AddCustomer(Customers customer);
        void UpdateCustomer(Customers customer);
        int GetCustomerIdByName(string firstName, string middleName, string lastName);

        //method to retrieve customer names
        List<string> GetCustomerNames();
    }

}
