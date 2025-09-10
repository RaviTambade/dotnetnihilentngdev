using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Portal.Models;

namespace Portal.Controllers;


//MVC Controller
public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {

        Console.WriteLine("HomeController instantiated");
        _logger = logger;
    }


    // Action Method
    // URL: /Home/Index
    //HTTP GET

    public IActionResult Index()
    {
        Console.WriteLine(" Home : Index action method called");

        //Write your own Request processing logic here
        string message = "ECommerce Portal for Selling Fresh Flowers";
        // Generating ViewResult object and returning to the caller
        return View();
    }

    // Action Method
    // URL: /Home/Privacy
    public IActionResult Privacy()
    {
        string message = "Your privacy is important to us.";
        return View();
    }

    // Action Method
    public IActionResult About()
    {
        string companyName = "Transflower Acceleration Program (TAP)";
        string vision = "To be the most trusted online flower delivery service.";
        string mission = "To deliver fresh flowers with exceptional service.";

        return Json(new {
            CompanyName = companyName,
            Vision = vision,
            Mission = mission
        });
        //return View();
    }

    // Action Method
    public IActionResult Contact()
    {
        string message = "Contact us for any inquiries.";
        string email = "ravi.tambade@transflower.in";
        string phone = "+91 9881735801";
        string address = "601  Rama Apartment, Pune - 411009";
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }


    ~HomeController()
    {
        Console.WriteLine("HomeController is getting DiInitialized by GC");
    }
}
