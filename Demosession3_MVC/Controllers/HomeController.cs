using Microsoft.AspNetCore.Mvc;

namespace Demosession3_MVC.Controllers;
[Route("Home")]
public class HomeController : Controller
{
    [Route("Index")]
    [Route("")]
    [Route("~/")]

    public IActionResult Index()
    {
        ViewBag.Title = "Home";
        return View();
    }
}
