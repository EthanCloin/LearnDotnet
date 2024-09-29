using System.Diagnostics;
using LearnDotnet.Models;
using Microsoft.AspNetCore.Mvc;

namespace LearnDotnet.Controllers;

public class MainController : Controller
{
    private readonly MainRepository repository;

    public MainController(MainRepository repository)
    {
        this.repository = repository;
    }
    public async Task<IActionResult> Orders()
    {
        var orders = await repository.GetOrders();
        return View("Orders", orders);
    }

    public async Task<IActionResult> Products([FromQuery] int? orderID)
    {
        IEnumerable<ProductModel> products;
        if (orderID == null)
        {
            products = await repository.GetProducts();
            Console.WriteLine("oop no id");
            return PartialView("Products", products);
        }
        products = await repository.GetProductsByOrder(orderID.Value);
       return PartialView("Products", products); 
    }

    public async Task<IActionResult> Ingredients([FromQuery] int? productID)
    {
        if (productID == null)
        {
            return PartialView("Ingredients");
        }
        var ingredients = await repository.GetIngredientsByProduct(productID.Value);
        return PartialView("Ingredients", ingredients);
    }

    public IActionResult Dashboard()
    {
        return View("Dashboard");
    }
}
