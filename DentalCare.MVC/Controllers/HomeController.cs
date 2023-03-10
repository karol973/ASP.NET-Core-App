using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using DentalCare.MVC.Models;

namespace DentalCare.MVC.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }
    public IActionResult About()
    {
        var model = new About()
        {
            Title = "Dental Care",
            Description = "Somee App",
            Tags = new List<string> { "doctor", "app" }
        };
        return View(model);
    }

    public IActionResult Privacy()
    {
        var model = new List<Person>()
        {
            new Person()
            {
                FirstName = "Karol",
                LastName="Przybysz",
            },
            new Person()
             {
                 FirstName = "Jacek",
                 LastName = "Berber",
             },
        };

        return View(model);
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
