using Microsoft.AspNetCore.Mvc;
using W8_AspCoreMVC.Models;

namespace W8_AspCoreMVC.Controllers;

public class CustomersController : Controller
{
    // GET
    public IActionResult Index()
    {
        var customer = new Customer
        {
            Id = 1,
            FirstName = "John",
            LastName = "Doe",
            Email = "john.doe@example.com"
        };

        var viewModel = new CustomerViewModel
        {
            Customer = customer,
            WelcomeMessage = "Welcome to our customer portal!"
        };
        
        return View(viewModel);
    }
}