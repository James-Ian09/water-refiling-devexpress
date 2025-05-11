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
        void AddStock(string itemName, int quantityToAdd);
        void RemoveStock(string itemName, int quantityToRemove);
        void UpdateStock(string itemName, int newQuantity);
    }
}

