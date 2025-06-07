using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WaterRefillingStationSystem.Models;

namespace WaterRefillingStationSystem.Interfaces
{
    public interface IStationSuppliesRepository
    {
        void AddNewItem(StationSupplies item);
        List<StationSupplies> GetAllSupplies();
        StationSupplies GetSupplyByName(string itemName);
        void UpdateSupplyItem(string oldName, string newName, int quantityChange, int newPrice);
        void DeleteSupply(string itemName);
    }
}

