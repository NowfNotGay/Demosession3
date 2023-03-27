using Microsoft.AspNetCore.Mvc;

namespace Demosession3_MVC.Areas.Admin.Controllers;
[Area("admin")]
[Route("admin/account")]

public class AccountController : Controller
{
    [Route("index")]
    [Route("")]

    public IActionResult Index()
    {
        return View();
    }
}
