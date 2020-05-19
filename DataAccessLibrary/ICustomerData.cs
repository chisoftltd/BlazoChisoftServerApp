using DataAccessLibrary.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataAccessLibrary
{
    public interface ICustomerData
    {
        Task<List<CustomerModel>> GetCustomers();
        Task InsertCustomer(CustomerModel customer);
    }
}