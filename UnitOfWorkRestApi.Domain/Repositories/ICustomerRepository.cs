using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitOfWorkRestApi.Domain.Entities;

namespace UnitOfWorkRestApi.Domain.Repositories
{
    public interface ICustomerRepository
    {
        void InsertCustomer(Customer customer);
        void UpdateCustomer(Customer customer);
        void DeleteCustomer(Customer Customer);
        Task<List<Customer>> GetAllCustomers();
        Task<Customer> GetCustomerById(int id);
    }
}
