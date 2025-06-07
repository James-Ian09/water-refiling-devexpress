using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WaterRefillingStationSystem.Interfaces;
using WaterRefillingStationSystem.Models;

namespace WaterRefillingStationSystem.Repositories
{
    public class StationSuppliesRepository : IStationSuppliesRepository
    {
        private string _connectionString = @"Data Source=C:\Users\krist\OneDrive\Desktop\OOP Programming\WaterRefillingStationSystem\WaterRefillingStationSystemDB.db;Version=3;";

        public void AddNewItem(StationSupplies item)
        {
            using (var connection = new SQLiteConnection(_connectionString))
            {
                connection.Open();
                string query = @"INSERT INTO StationSupplies (ItemName, UnitPrice, Quantity) 
                             VALUES (@ItemName, @UnitPrice, @Quantity)";
                connection.Execute(query, item);
            }
        }

        public List<StationSupplies> GetAllSupplies()
        {
            using (var connection = new SQLiteConnection(_connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM StationSupplies";
                return connection.Query<StationSupplies>(query).ToList();
            }
        }

        public StationSupplies GetSupplyByName(string itemName)
        {
            using (var connection = new SQLiteConnection(_connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM StationSupplies WHERE ItemName = @ItemName";
                return connection.QueryFirstOrDefault<StationSupplies>(query, new { ItemName = itemName });
            }
        }
        public void UpdateSupplyItem(string oldName, string newName, int quantityChange, int newPrice)
        {
            using (var connection = new SQLiteConnection(_connectionString))
            {
                connection.Open();

                //Ensure item exists before updating
                string checkItemQuery = "SELECT COUNT(*) FROM StationSupplies WHERE ItemName = @oldName";
                int itemExists = connection.ExecuteScalar<int>(checkItemQuery, new { oldName });

                if (itemExists == 0)
                {
                    throw new Exception("Item not found in inventory.");
                }

                //Update item name first before modifying stock and price
                if (oldName != newName)
                {
                    string renameQuery = "UPDATE StationSupplies SET ItemName = @newName WHERE ItemName = @oldName";
                    connection.Execute(renameQuery, new { oldName, newName });
                }

                //Update stock and price after renaming the item
                string updateQuery = @"UPDATE StationSupplies 
                               SET Quantity = Quantity + @quantityChange, 
                                   UnitPrice = @newPrice 
                               WHERE ItemName = @newName"; //Now uses updated name
                connection.Execute(updateQuery, new { newName, quantityChange, newPrice });
            }
        }
        public void DeleteSupply(string itemName)
        {
            using (var connection = new SQLiteConnection(_connectionString))
            {
                connection.Open();
                string query = "DELETE FROM StationSupplies WHERE ItemName = @itemName";
                connection.Execute(query, new { itemName });
            }
        }
    }
}
