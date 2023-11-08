using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers;

public class LanchoneteController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Pastel()
    {
        return Pastel();
    }

    public IActionResult Coxinha()
    {
        return Coxinha();
    }
    
    
}