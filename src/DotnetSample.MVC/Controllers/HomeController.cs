using System.Diagnostics;
using System.Reflection;
using DotnetSample.MVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace DotnetSample.MVC.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        ViewData["ControllerName"] = GetType().Name;
        ViewBag.ActionName = MethodBase.GetCurrentMethod()?.Name;
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
