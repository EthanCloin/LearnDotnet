using System.Diagnostics;
using LearnDotnet.Models;
using Microsoft.AspNetCore.Mvc;

namespace LearnDotnet.Controllers;

public class MainController : Controller
{
    public IActionResult Orders()
    {
        return View("OrderExpander");
    }
}
