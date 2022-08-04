using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UnitOfWorkRestApi.Domain.Entities;
using UnitOfWorkRestApi.Domain.Repositories;
using UnitOfWorkRestApi.Domain.UnitOfWork;

namespace UnitOfWorkRestApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {

        [HttpPost]
        public IActionResult Post
            (
                [FromServices] IUnitOfWork unitOfWork 
            ) 
        {
            var customer = new Customer() { Name = "Joselito" };

            var orderItem = new OrderItem() 
            {
                Name = "Pizza Calabresa",
                Price = 10,
            };

            var order = new Order(customer);
            order.AddOrderItem(orderItem);

            unitOfWork.CustomerRepository.InsertCustomer(customer);
            unitOfWork.OrderItemRepository.InsertOrderItem(orderItem);
            unitOfWork.OrderRepository.InsertOrder(order);

            unitOfWork.SaveChanges();

            return Ok();
        }
    }
}
