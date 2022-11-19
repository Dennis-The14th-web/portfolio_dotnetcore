using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Portfolio_dotnetcore.Models;

namespace Portfolio_dotnetcore.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index(int id)
    {
        var newModel = new Book
        {
            Title = "I'm a passionate full-stack web developer",
            Author = "Dennis Itua"
        };
        return View(newModel);
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

