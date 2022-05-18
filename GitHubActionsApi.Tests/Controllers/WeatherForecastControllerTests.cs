using GitHubActionsApi.Controllers;
using Microsoft.Extensions.Logging;

namespace GitHubActionsApi.Tests.Controllers;
public class WeatherForecastControllerTests
{
    private WeatherForecastController _controller;
    private ILogger<WeatherForecastController> _logger;

    public WeatherForecastControllerTests()
    {
        _logger = Substitute.For<ILogger<WeatherForecastController>>();
        _controller = new WeatherForecastController(_logger);
    }

    [Fact]
    public void Get_ReturnsWeather()
    {
        var result = _controller.Get();
        result.ShouldNotBeNull();
    }
}
