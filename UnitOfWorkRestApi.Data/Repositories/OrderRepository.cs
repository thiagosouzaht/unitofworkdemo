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
    public class OrderRepository : IOrderRepository
    {
        private readonly AppDbContext _appDbContext;

        public OrderRepository(AppDbContext appDbCoontext)
        {
            _appDbContext = appDbCoontext;
        }

        public async Task DeleteOrderById(int id)
        {
            var orderToRemove = await _appDbContext.Orders.FirstOrDefaultAsync(a => a.Id == id);
            _appDbContext.Orders.Remove(orderToRemove);
        }

        public async Task<List<Order>> GetAllOrders()
        {
            return await _appDbContext.Orders.ToListAsync();
        }

        public async Task<Order> GetOrderById(int id)
        {
            return await _appDbContext.Orders.FirstOrDefaultAsync(a => a.Id == id);
        }

        public async void InsertOrder(Order order)
        {
            await _appDbContext.Orders.AddAsync(order);
        }

        public void UpdateOrder(Order order)
        {
            _appDbContext.Orders.Update(order);
        }
    }
}
