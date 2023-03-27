using Microsoft.AspNetCore.Mvc;

namespace FlowerShop.Areas.Admin.Controllers;
[Area("admin")]
[Route("admin/product")]
public class ProductController : Controller
{
    [Route("index")]
    [Route("")]

    public IActionResult Index()
    {
        return View();
    }

    [Route("addproduct")]

    public IActionResult AddProduct()
    {
        return View();
    }
}
