using Microsoft.AspNetCore.Mvc;

namespace FlowerShop.Controllers;
public class ViewCartController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}
