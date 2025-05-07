using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WaterRefillingStationSystem.Models;

namespace WaterRefillingStationSystem.Interfaces
{
    public interface ICustomerDebtRepository
    {
        void AddDebtRecord(CustomerDebt debtRecord);
        List<CustomerDebt> GetAllDebtRecords();
        void RemoveDebtRecord(string name, DateTime orderDate);
        void MarkDebtAsPaid(string customerName, DateTime orderDate);
    }
}
