using Microsoft.AspNetCore.Mvc;

namespace Demosession3_MVC.Controllers;
[Route("aboutus")]
public class AboutUsController : Controller
{
    [Route("Index")]
    public IActionResult Index()
    {
        return View();
    }
}
