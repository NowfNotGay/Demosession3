using Microsoft.AspNetCore.Mvc;

namespace FlowerShop.Areas.Controllers;
[Area("admin")]
[Route("admin")]
[Route("admin/account")]
public class AccountController : Controller
{
    [Route("Login")]
    [Route("")]

    public IActionResult Login()
    {
        return View("Login");
    }
}
