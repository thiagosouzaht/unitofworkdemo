using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitOfWorkRestApi.Domain.Repositories;
using UnitOfWorkRestApi.Domain.UnitOfWork;

namespace UnitOfWorkRestApi.Data.Repositories.RepositoryConfiguration
{
    public static class RepositoryConfiguration
    {
        public static void AddRepositoryConfiguration(this IServiceCollection services)
        {
            services.AddScoped<IUnitOfWork, UnitOfWork.UnitOfWork>();
            services.AddScoped<IOrderRepository, OrderRepository>();
            services.AddScoped<IOrderItemRepository, OrderItemRepository>();
            services.AddScoped<ICustomerRepository, CustomerRepository>();
        }
    }
}
