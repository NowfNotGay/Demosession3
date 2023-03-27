using Microsoft.AspNetCore.Mvc;

namespace ShopBoot.Controllers;
[Route("Contact")]

public class ContactController : Controller
{
    [Route("Index")]
    [Route("")]

    public IActionResult Index()
    {
        return View();
    }
}
