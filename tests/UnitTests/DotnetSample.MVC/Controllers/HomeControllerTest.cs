using DotnetSample.MVC.Controllers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace UnitTests.DotnetSample.MVC.Controllers;

public class HomeControllerTest
{
    [Fact]
    public void Index_Test_SampleCase()
    {
        var mock = new Mock<ILogger<HomeController>>();
        var controller = new HomeController(mock.Object);
        var result = controller.Index();

        var response = Assert.IsType<ViewResult>(result);

        var controllerName = Assert.IsAssignableFrom<string>(response.ViewData["ControllerName"]);
        Assert.Equal("HomeController", controllerName);

        var actionName = Assert.IsAssignableFrom<string>(response.ViewData["ActionName"]);
        Assert.Equal("Index", actionName);
    }
}

