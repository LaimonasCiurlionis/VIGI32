using Microsoft.AspNetCore.Mvc;

namespace MyFirstAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public IEnumerable<WeatherForecast> Get()
        {
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
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