using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitOfWorkRestApi.Domain.Entities;

namespace UnitOfWorkRestApi.Domain.Repositories
{
    public interface IOrderItemRepository
    {
        void InsertOrderItem(OrderItem orderItem);
        void UpdateOrderItem(OrderItem orderItem);
        void DeleteOrderItem(OrderItem orderItem);
        Task<List<OrderItem>> GetAllOrderItems();
        Task<OrderItem> GetOrderItemById(int id);
    }
}
