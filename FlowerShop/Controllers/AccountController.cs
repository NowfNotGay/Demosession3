using Microsoft.AspNetCore.Mvc;

namespace FlowerShop.Controllers;
public class AccountController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
    public IActionResult Register()
    {
        return View();
    }

}
