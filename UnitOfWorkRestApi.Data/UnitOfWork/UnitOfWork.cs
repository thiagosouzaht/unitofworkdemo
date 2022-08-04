using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitOfWorkRestApi.Data.Persistence;
using UnitOfWorkRestApi.Domain.Repositories;
using UnitOfWorkRestApi.Domain.UnitOfWork;

namespace UnitOfWorkRestApi.Data.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext _appDbContext;

        public IOrderRepository OrderRepository { get; set; }
        public IOrderItemRepository OrderItemRepository { get; set; }
        public ICustomerRepository CustomerRepository { get; set; }

        public UnitOfWork(
            AppDbContext appDbContext,
            IOrderRepository orderRepository,
            IOrderItemRepository orderItemRepository,
            ICustomerRepository customerRepository
            )
        {
            _appDbContext = appDbContext;
            OrderItemRepository = orderItemRepository;
            OrderRepository = orderRepository;
            CustomerRepository = customerRepository;
        }

        public void SaveChanges()
        {
            _appDbContext.SaveChanges(); 
        }

        public void RollBack()
        {
            
        }
    }
}
