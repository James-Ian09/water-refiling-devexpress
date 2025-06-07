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
        void RemoveDebtRecord(int debtID);
        void MarkDebtAsPaid(string customerName, string orderDate);
    }
}
