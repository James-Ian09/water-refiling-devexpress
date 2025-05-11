using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WaterRefillingStationSystem.Interfaces;

namespace WaterRefillingStationSystem.Repositories
{
    public class SaleRepository : ISaleRepository
    {
        private readonly string _connectionString = @"Data Source=C:\Users\krist\OneDrive\Desktop\OOP Programming\WaterRefillingStationSystem\WaterRefillingStationSystemDB.db;Version=3;";

        public void AddSale(string orderType, string itemName, int quantity, int unitPrice, int totalPrice, string orderDate)
        {
            using (var connection = new SQLiteConnection(_connectionString))
            {
                connection.Open();
                string salesQuery = @"INSERT INTO SalesDetails (OrderType, ItemName, Quantity, UnitPrice, TotalPrice, OrderDate) 
                                      VALUES (@OrderType, @ItemName, @Quantity, @UnitPrice, @TotalPrice, @OrderDate)";
                connection.Execute(salesQuery, new
                {
                    OrderType = orderType,
                    ItemName = itemName,
                    Quantity = quantity,
                    UnitPrice = unitPrice,
                    TotalPrice = totalPrice,
                    OrderDate = orderDate
                });
            }
        }
        public List<(string FirstName, string MiddleName, string LastName)> GetCustomerNames()
        {
            using (var connection = new SQLiteConnection(_connectionString))
            {
                connection.Open();
                string query = "SELECT FirstName, MiddleName, LastName FROM Customers";
                return connection.Query<(string FirstName, string MiddleName, string LastName)>(query).ToList();
            }
        }
        public int GetCustomerIdByName(string firstName, string lastName)
        {
            using (var connection = new SQLiteConnection(_connectionString))
            {
                connection.Open();
                string query = @"SELECT CustomerID FROM Customers WHERE FirstName = @FirstName AND LastName = @LastName";
                return connection.ExecuteScalar<int>(query, new { FirstName = firstName, LastName = lastName });
            }
        }
    }
}
