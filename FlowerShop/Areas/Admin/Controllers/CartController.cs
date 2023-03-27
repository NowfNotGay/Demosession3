using Microsoft.AspNetCore.Mvc;

namespace FlowerShop.Areas.Admin.Controllers;
[Area("admin")]
[Route("admin/cart")]
public class CartController : Controller
{
    [Route("index")]
    [Route("")]
    public IActionResult Index()
    {
        return View();
    }
}
