using Microsoft.AspNetCore.Mvc;

namespace Demosession3_MVC.Controllers;
[Route("Contact")]
public class ContactController : Controller
{
    [Route("Contact1")]
    [Route("")]

    public IActionResult Contact1()
    {
        return View();
    }

    [Route("Contact2")]

    public IActionResult Contact2()
    {
        return View();
    }
}
