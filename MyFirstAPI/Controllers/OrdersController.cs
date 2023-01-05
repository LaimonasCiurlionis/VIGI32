using Microsoft.AspNetCore.Mvc;

namespace MyFirstAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OrdersController : ControllerBase
    {
        private static List<Order> Orders = new List<Order>();
        public OrdersController()
        {

        }

        [HttpGet]
        public List<Order> Get()
        {
            return Orders;
        }

        [HttpGet("id")]
        public Order Get([FromQuery] int id)
        {
            return Orders.Single(x => x.Id == id);
        }

        [HttpPut]
        public Order Update([FromBody] OrderRequestModel request)
        {
            var order = Orders.Single(x => x.Id == request.Id);
            order.Price = request.Price;
            order.Name = request.Name;
            return order;
        }

        [HttpDelete("id")]
        public Order Delete(int id)
        {
            var order = Orders.Single(x => x.Id == id);
            Orders.Remove(order);
            return order;
        }

        [HttpPost]
        public Order Create([FromBody] OrderRequestModel request)
        {
            var order = new Order
            {
                Id = Orders.Count + 1,
                Name = request.Name,
                Price = request.Price,
                Created = DateTime.Now
            };
            Orders.Add(order);
            return order;
        }
    }
}