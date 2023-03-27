using Microsoft.AspNetCore.Mvc;

namespace ShopBoot.Controllers;
public class DeliverController : Controller
{
    public IActionResult Index()
    {
        ViewBag.SideBar = "a";
        return View();
    }
}
