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
        return View("OrderExpander", orders);
    }
}
