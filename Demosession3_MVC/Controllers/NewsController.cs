using Microsoft.AspNetCore.Mvc;

namespace Demosession3_MVC.Controllers;
[Route("news")]

public class NewsController : Controller
{
    [Route("Index")]
    public IActionResult Index()
    {
        return View();
    }
}
