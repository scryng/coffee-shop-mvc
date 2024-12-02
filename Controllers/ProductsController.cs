using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace Cafeteria.Controllers;

public class ProductsController : Controller
{
    // 
    // GET: /Products/
    public string Index()
    {
        return "This is my default action...";
    }
    // 
    // GET: /Products/Welcome/ 
    public string Welcome(string name, int ID = 1)
    {
        return HtmlEncoder.Default.Encode($"Hello {name}, ID: {ID}");
    }
}