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
    public class CustomerRepository : ICustomerRepository
    {
        private string _connectionString = @"Data Source=C:\Users\krist\OneDrive\Desktop\OOP Programming\WaterRefillingStationSystem\WaterRefillingStationSystemDB.db;Version=3;";

        public List<Customers> GetAllCustomers()
        {
            using (var connection = new SQLiteConnection(_connectionString))
            {
                connection.Open();
                string query = "SELECT CustomerID, FirstName, MiddleName, LastName, ContactNumber, Address FROM Customers";
                return connection.Query<Customers>(query).ToList();
            }
        }
        public Customers GetCustomerById(int customerId)
        {
            using (var connection = new SQLiteConnection(_connectionString))
            {
                connection.Open();
                string query = "SELECT CustomerID, FirstName, MiddleName, LastName, ContactNumber, Address FROM Customers WHERE CustomerID = @Id";
                return connection.QuerySingleOrDefault<Customers>(query, new { Id = customerId });
            }
        }
        public int GetCustomerIdByName(string firstName, string middleName, string lastName)
        {
            using (var connection = new SQLiteConnection(_connectionString))
            {
                connection.Open();

                //If middle name is empty, remove extra space to prevent mismatches
                string fullName = string.IsNullOrWhiteSpace(middleName) ? $"{firstName} {lastName}" : $"{firstName} {middleName} {lastName}";

                string query = @"SELECT CustomerID FROM Customers 
                         WHERE TRIM(FirstName || ' ' || MiddleName || ' ' || LastName) = @FullName";

                int customerID = connection.ExecuteScalar<int>(query, new { FullName = fullName.Trim() });

                return customerID;
            }
        }
        public List<string> GetCustomerNames()
        {
            using (var connection = new SQLiteConnection(_connectionString))
            {
                connection.Open();
                string query = "SELECT FirstName || ' ' || MiddleName || ' ' || LastName AS FullName FROM Customers";
                return connection.Query<string>(query).ToList();
            }
        }
        public void AddCustomer(Customers customer)
        {
            using (var connection = new SQLiteConnection(_connectionString))
            {
                connection.Open();
                string insertQuery = @"INSERT INTO Customers (FirstName, MiddleName, LastName, ContactNumber, Address) 
                                   VALUES (@FirstName, @MiddleName, @LastName, @ContactNumber, @Address)";
                connection.Execute(insertQuery, customer);
            }
        }
        public void RemoveCustomer(int customerID)
        {
            using (var connection = new SQLiteConnection(_connectionString))
            {
                connection.Open();
                string query = "DELETE FROM Customers WHERE CustomerID = @CustomerID";
                connection.Execute(query, new { CustomerID = customerID });
            }
        }
        public void UpdateCustomer(Customers customer)
        {
            using (var connection = new SQLiteConnection(_connectionString))
            {
                connection.Open();
                string updateQuery = @"UPDATE Customers 
                                   SET FirstName = @FirstName, MiddleName = @MiddleName, LastName = @LastName, ContactNumber = @ContactNumber, Address = @Address
                                   WHERE CustomerID = @CustomerID";
                connection.Execute(updateQuery, customer);
            }
        }
    }
}
