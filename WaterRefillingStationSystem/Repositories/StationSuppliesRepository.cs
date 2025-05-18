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

        public void AddStock(string itemName, int quantityToAdd)
        {
            using (var connection = new SQLiteConnection(_connectionString))
            {
                connection.Open();
                string query = @"UPDATE StationSupplies SET Quantity = Quantity + @quantityToAdd WHERE ItemName = @itemName";
                connection.Execute(query, new { itemName, quantityToAdd });
            }
        }

        public void RemoveStock(string itemName, int quantityToRemove)
        {
            using (var connection = new SQLiteConnection(_connectionString))
            {
                connection.Open();

                //Check current stock before deducting
                string checkStockQuery = "SELECT Quantity FROM StationSupplies WHERE ItemName = @itemName";
                int currentStock = connection.ExecuteScalar<int>(checkStockQuery, new { itemName });

                if (currentStock < quantityToRemove)
                {
                    throw new Exception("Insufficient stock available."); //Prevents over-selling
                }

                //Reduce stock only if sufficient
                string updateStockQuery = @"UPDATE StationSupplies SET Quantity = Quantity - @quantityToRemove WHERE ItemName = @itemName";
                connection.Execute(updateStockQuery, new { itemName, quantityToRemove });
            }
        }
    }
}
