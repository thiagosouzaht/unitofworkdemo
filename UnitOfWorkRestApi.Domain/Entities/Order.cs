using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitOfWorkRestApi.Domain.Entities
{
    public class Order
    {
        public int Id { get; set; }
        public List<OrderItem> OrderItems { get; set; }
        public Customer Customer { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime LastModified { get; set; }

        public Order(Customer customer)
        {
            Customer = customer;
            CreatedAt = DateTime.Now;
            LastModified = DateTime.Now;

            OrderItems = new List<OrderItem>();
        }

        public Order() {}

        public void AddOrderItem(OrderItem orderItem) 
        {
            OrderItems.Add(orderItem);
        }

        public void RemoveOrderItem(OrderItem orderItem) 
        {
            OrderItems.Remove(orderItem);
        }

        public decimal TotalOrderValue()
        {
            return OrderItems.Sum(OrderItems => OrderItems.Price);
        }

        public decimal TotalOrderValueWithServiceFee()
        {
            return OrderItems.Sum(OrderItems => OrderItems.Price) * (decimal) 1.10;
        }
    }
}
