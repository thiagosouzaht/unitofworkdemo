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
    public class OrderItemRepository : IOrderItemRepository
    {
        private readonly AppDbContext _appDbContext;

        public OrderItemRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public void DeleteOrderItem(OrderItem orderItem)
        {
            _appDbContext.OrderItems.Remove(orderItem);
        }

        public async Task<List<OrderItem>> GetAllOrderItems()
        {
            return await _appDbContext.OrderItems.ToListAsync();
        }

        public async Task<OrderItem> GetOrderItemById(int id)
        {
            return await _appDbContext.OrderItems.FirstOrDefaultAsync(a => a.Id == id);
        }

        public void InsertOrderItem(OrderItem orderItem)
        {
            _appDbContext.OrderItems.Add(orderItem);
        }

        public void UpdateOrderItem(OrderItem orderItem)
        {
            _appDbContext.OrderItems.Update(orderItem);
        }
    }
}
