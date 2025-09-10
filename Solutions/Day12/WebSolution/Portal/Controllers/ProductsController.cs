
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Portal.Models;

namespace Portal.Controllers;


//Single Responsibility Principle :
//Controller should have single responsibility
//Controller is nothing but a class
//Responsible for handling incoming HTTP requests
//Responsible for processing the request
//Responsible for generating appropriate HTTP response

//MVC Controller
public class ProductsController : Controller
{
    private readonly ILogger<ProductsController> _logger;

    public ProductsController(ILogger<ProductsController> logger)
    {
        _logger = logger;
    }

    //Action Methods
    // URL: /Products/Index
    public IActionResult Index()
    {
        // In real application, fetch product list from database
        var products = new List<Product>
        {
            new Product { Id = 1, Name = "Rose Bouquet", Price = 29.99M },
            new Product { Id = 2, Name = "Tulip Bouquet", Price = 19.99M },
            new Product { Id = 3, Name = "Lily Bouquet", Price = 24.99M }
        };
        return View(products);
        // return Json(products);
    }

    // Action Method
    // URL: /Products/Details/1
    public IActionResult Details(int id)
    {
        // In real application, fetch product details from database
        //service call to fetch product by id from Repository from JSON file or Database
        var product = new Product { Id = id, Name = "Rose Bouquet", Price = 29.99M, Description = "A beautiful bouquet of red roses.", ImageUrl = "/images/rose.jpg" };

        return View(product);
    }

    // CRUD Operations Actions Methods can be added here

}