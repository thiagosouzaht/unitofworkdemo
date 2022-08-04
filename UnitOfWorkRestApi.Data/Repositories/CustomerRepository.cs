using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitOfWorkRestApi.Data.Persistence;
using UnitOfWorkRestApi.Domain.Entities;
using UnitOfWorkRestApi.Domain.Repositories;

namespace UnitOfWorkRestApi.Data.Repositories
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly AppDbContext _appDbContext;

        public CustomerRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public void DeleteCustomer(Customer Customer)
        {
            _appDbContext.Customers.Remove(Customer);
        }

        public async Task<List<Customer>> GetAllCustomers()
        {
            return await _appDbContext.Customers.ToListAsync();
        }

        public async Task<Customer> GetCustomerById(int id)
        {
            return await _appDbContext.Customers.FirstOrDefaultAsync(a => a.Id == id);
        }

        public void InsertCustomer(Customer customer)
        {
            _appDbContext.Customers.Add(customer);
        }

        public void UpdateCustomer(Customer customer)
        {
            _appDbContext.Customers.Update(customer);
        }
    }
}
