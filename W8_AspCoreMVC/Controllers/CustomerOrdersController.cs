using Microsoft.AspNetCore.Mvc;
using W8_AspCoreMVC.Models;

namespace W8_AspCoreMVC.Controllers;

public class CustomerOrdersController : Controller
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

        var firstOrder = new Order
        {
            Id = 1,
            ProductName = "Product A",
            Price = 49.99m,
            Quantity = 2
        };
        
        var secondOrder = new Order
        {
            Id = 2,
            ProductName = "Product B",
            Price = 99.99m,
            Quantity = 2
        };
        
        var thirdOrder = new Order
        {
            Id = 3,
            ProductName = "Product C",
            Price = 149.99m,
            Quantity = 1
        };

        var viewModel = new CustomerOrderViewModel
        {
            Customer = customer,
            Orders = new List<Order>
            {
                firstOrder,
                secondOrder,
                thirdOrder
            }
        };
        
        return View(viewModel);
    }
}