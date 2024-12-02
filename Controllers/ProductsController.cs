using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace Cafeteria.Controllers;

public class ProductsController : Controller
{
    // 
    // GET: /Products/
    public IActionResult Index()
    {
        return View();
    }
    // 
    // GET: /Products/Welcome/ 
    public string Welcome(string name, int ID = 1)
    {
        return HtmlEncoder.Default.Encode($"Hello {name}, ID: {ID}");
    }
}