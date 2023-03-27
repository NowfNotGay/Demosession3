using Microsoft.AspNetCore.Mvc;

namespace FlowerShop.Controllers;
public class AboutUsController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}
