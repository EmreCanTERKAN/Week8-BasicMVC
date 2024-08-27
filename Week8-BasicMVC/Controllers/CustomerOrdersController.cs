using Microsoft.AspNetCore.Mvc;
using Week8_BasicMVC.Models.ViewModels;
using Week8_BasicMVC.Models;

namespace Week8_BasicMVC.Controllers
{
    public class CustomerOrdersController : Controller
    {
        public IActionResult Index()
        {
            var customer = new Customer
            {
                Id = 1,
                FirstName = "Emre",
                LastName = "Can",
                Email = "emrecanterkan06@gmail.com"
            };

            var orders = new List<Order>
        {
            new Order { Id = 1, ProductName = "Laptop", Price = 1500.00M, Quantity = 1 },
            new Order { Id = 2, ProductName = "Mouse", Price = 20.00M, Quantity = 2 },
            new Order { Id = 3, ProductName = "Klavye", Price = 50.00M, Quantity = 1 }
        };

            // ViewModel'i oluşturma
            var viewModel = new CustomerOrderViewModel
            {
                Customer = customer,
                Orders = orders
            };

            // View'a ViewModel'i iletme
            return View(viewModel);
        }
    }
}
