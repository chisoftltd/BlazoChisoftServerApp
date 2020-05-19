using DataAccessLibrary.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLibrary
{
    public class CustomerData : ICustomerData
    {
        private readonly ISqlDataAccess _db;

        public CustomerData(ISqlDataAccess db)
        {
            _db = db;
        }

        public Task<List<CustomerModel>> GetCustomers()
        {
            string sql = "select * from dbo.Customer";
            return _db.LoadData<CustomerModel, dynamic>(sql, new { });
        }

        public Task InsertCustomer(CustomerModel customer)
        {
            string sql = @"insert into dbo.Customer (FirstName, LastName, Age, City)
                        values (@FirstName, @LastName, @Age, @City);";

            return _db.SaveData(sql, customer);
        }
    }
}
