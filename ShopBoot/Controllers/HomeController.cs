using Microsoft.AspNetCore.Mvc;

namespace ShopBoot.Controllers;
[Route("Home")]
public class HomeController : Controller
{
    [Route("Index")]
    [Route("")]
    [Route("~/")]

    public IActionResult Index()
    {
        ViewBag.SideBar = "a";
        return View();
    }
}
