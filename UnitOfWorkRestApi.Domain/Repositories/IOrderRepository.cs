using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitOfWorkRestApi.Domain.Entities;

namespace UnitOfWorkRestApi.Domain.Repositories
{
    public interface IOrderRepository
    {
        void InsertOrder(Order order);
        void UpdateOrder(Order order);
        Task<Order> GetOrderById(int id);
        Task DeleteOrderById(int id);
        Task<List<Order>> GetAllOrders();
    }
}
