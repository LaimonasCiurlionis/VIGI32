namespace WebApplication1.Controllers
{
    public class Order
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public DateTime Created { get; set; }
    }
}
}