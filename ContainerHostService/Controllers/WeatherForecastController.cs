using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.Cosmos;
using System.ComponentModel;

namespace ContainerHostService.Controllers
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
        public async Task<WeatherForecast> GetAsync()
        {
            CosmosClientOptions options = new()
            {
                HttpClientFactory = () => new HttpClient(new HttpClientHandler()
                {
                    ServerCertificateCustomValidationCallback = HttpClientHandler.DangerousAcceptAnyServerCertificateValidator
                }),
                ConnectionMode = ConnectionMode.Gateway,
            };
            var client = new CosmosClient(
                "AccountEndpoint=https://host.docker.internal:8081/;AccountKey=C2y6yDjf5/R+ob0N8A7Cgv30VRDJIWEHLM+4QDU5DE2nQ9nDuVTqobD4b8mGGyPMbIZnqyMsEcaGQy67XIw/Jw=="
                //,options
                );

            var databaseName = "ContainerHostServiceDb";
            var containerName = "weather_cn";

//            await client.CreateDatabaseIfNotExistsAsync(databaseName);
            var database = client.GetDatabase(databaseName);

            var containerProps = new ContainerProperties()
            {
                Id = "weather_cn",
                PartitionKeyPath = $"/Date",
            };            
  //          await database.CreateContainerIfNotExistsAsync(containerProps);

            var container = client.GetContainer(databaseId: databaseName, containerId: containerName);

            

            var data = new WeatherForecast
            {
                Date = DateOnly.FromDateTime(DateTime.Now.AddDays(1)),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            };
            await container.CreateItemAsync(data);

            return data;
        }
    }
}
