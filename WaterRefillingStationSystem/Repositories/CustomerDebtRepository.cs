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
    public class CustomerDebtRepository : ICustomerDebtRepository
    {
        private string _connectionString = @"Data Source=C:\Users\krist\OneDrive\Desktop\OOP Programming\WaterRefillingStationSystem\WaterRefillingStationSystemDB.db;Version=3;";

        public void AddDebtRecord(CustomerDebt debtRecord)
        {
            using (var connection = new SQLiteConnection(_connectionString))
            {
                connection.Open();
                string query = @"INSERT INTO CustomerDebt (Name, OrderType, ItemName, Quantity, UnitPrice, OrderDate, Debt) 
                         VALUES (@Name, @OrderType, @ItemName, @Quantity, @UnitPrice, @OrderDate, @Debt)";
                connection.Execute(query, new
                {
                    Name = debtRecord.Name,
                    OrderType = debtRecord.OrderType,
                    ItemName = debtRecord.ItemName,
                    Quantity = debtRecord.Quantity,
                    UnitPrice = debtRecord.UnitPrice,
                    Debt = debtRecord.Debt,

                    //Convert OrderDate to store only date without time
                    OrderDate = debtRecord.OrderDate.ToString("yyyy-MM-dd")
                });
            }
        }

        public List<CustomerDebt> GetAllDebtRecords()
        {
            using (var connection = new SQLiteConnection(_connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM CustomerDebt";
                return connection.Query<CustomerDebt>(query).ToList();
            }
        }

        public void RemoveDebtRecord(int debtID)
        {
            using (var connection = new SQLiteConnection(_connectionString))
            {
                connection.Open();
                string query = "DELETE FROM CustomerDebt WHERE DebtID = @DebtID"; //using DebtID for deletion
                connection.Execute(query, new { DebtID = debtID });
            }
        }
        public void MarkDebtAsPaid(string customerName, string orderDate)
        {
            using (var connection = new SQLiteConnection(_connectionString))
            {
                connection.Open();

                //Retrieve the debt record first
                string selectQuery = "SELECT * FROM CustomerDebt WHERE Name = @Name AND OrderDate = @OrderDate";
                var debtRecord = connection.QuerySingleOrDefault<CustomerDebt>(selectQuery, new { Name = customerName, OrderDate = orderDate });

                if (debtRecord == null)
                {
                    throw new Exception("Debt record not found."); //Handle missing record
                }

                // ✅ Now debtRecord exists and can be used
                string insertQuery = @"INSERT INTO SalesDetails (OrderType, ItemName, Quantity, UnitPrice, TotalPrice, OrderDate) 
                               VALUES (@OrderType, @ItemName, @Quantity, @UnitPrice, @TotalPrice, @OrderDate)";
                connection.Execute(insertQuery, new
                {
                    OrderType = debtRecord.OrderType,
                    ItemName = debtRecord.ItemName,
                    Quantity = debtRecord.Quantity,
                    UnitPrice = debtRecord.UnitPrice,
                    TotalPrice = debtRecord.Debt,
                    OrderDate = debtRecord.OrderDate
                });

                //Remove debt after marking it as paid
                string deleteQuery = "DELETE FROM CustomerDebt WHERE Name = @Name AND OrderDate = @OrderDate";
                connection.Execute(deleteQuery, new { Name = debtRecord.Name, OrderDate = debtRecord.OrderDate });
            }
        }

    }
}
