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
    // Requires using System.Text.Encodings.Web;
    public string Welcome(string name, int numTimes = 1)
    {
    return HtmlEncoder.Default.Encode($"Hello {name}, NumTimes is: {numTimes}");
    }
}