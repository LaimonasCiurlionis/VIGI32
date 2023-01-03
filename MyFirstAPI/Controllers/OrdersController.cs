using Microsoft.AspNetCore.Mvc;

namespace MyFirstAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OrdersController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<WeatherForecast> Get()
        {
            return null;
        }

        [HttpPost]
        public IEnumerable<WeatherForecast> Add([FromBody] TestPost request)
        {
            //Creating new resource


            return null;
        }

        [HttpPut]
        public IEnumerable<WeatherForecast> Update([FromBody] TestPost request)
        {
            //Creating new resource


            return null;
        }

        [HttpDelete]
        public IEnumerable<WeatherForecast> Delete([FromBody] TestPost request)
        {
            //Creating new resource


            return null;
        }
    }
}
