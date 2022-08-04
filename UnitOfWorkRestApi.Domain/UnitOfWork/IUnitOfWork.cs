using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitOfWorkRestApi.Domain.Repositories;

namespace UnitOfWorkRestApi.Domain.UnitOfWork
{
    public interface IUnitOfWork
    {
        void SaveChanges();
        void RollBack();

        IOrderRepository OrderRepository { get; set; }
        IOrderItemRepository OrderItemRepository{ get; set; }
        ICustomerRepository CustomerRepository { get; set; }
    }
}
