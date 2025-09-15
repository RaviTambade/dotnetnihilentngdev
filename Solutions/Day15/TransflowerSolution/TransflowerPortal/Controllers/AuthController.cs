
namespace TransflowerPortal.Controllers;

using CatalogEntities;
using CatalogServices;
using Microsoft.AspNetCore.Mvc;

//it provides enum, classes, interfaces,
//delegates, events for building ASP.NET Core applications.

public class AuthController : Controller
{


    //Dependency Injection for ICustomerService, CustomerService
    
    public AuthController()
    {

    }


    [HttpGet]   //attribute , Decorator, Annotation, Metadata
                //Action Filter
    public IActionResult Login()
    {

        return View();
    }


    [HttpPost]
     public IActionResult Login(string email, string password)
    {

        if (email == "ravi.tambade@transflower.in" && password == "seed")
        {
           // this.Response.Redirect("/home/index");
            this.Response.Redirect("/products/index");
        }
         
        return View();
    }



    public IActionResult Register()
    {
        return View();
    }

}