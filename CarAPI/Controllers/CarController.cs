using Microsoft.AspNetCore.Mvc;

namespace CarAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CarController : ControllerBase
    {
        private readonly ICarRepository _carRepository;

        public CarController(ICarRepository carRepository)
        {
            _carRepository = carRepository;
        }

        [HttpGet]
        public List<Car> Get()
        {
            return _carRepository.GetAll();
        }

        [HttpGet("color")]
        public List<Car> GetByColor([FromQuery] string color)
        {
            return _carRepository.GetCarsByColor(color);
        }

        [HttpPost]
        public Car Add([FromBody] CarRequestModel car)
        {
            return _carRepository.AddNewCar(car);
        }

        [HttpPut]
        public Car Update([FromQuery] int id, [FromBody] CarRequestModel car)
        {
            return _carRepository.UpdateCar(id, car);
        }

        [HttpDelete]
        public Car Delete([FromQuery] int id)
        {
            return _carRepository.Delete(id);
        }
    }
}
