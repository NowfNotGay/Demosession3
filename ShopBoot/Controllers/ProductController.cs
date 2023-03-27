using Microsoft.AspNetCore.Mvc;

namespace ShopBoot.Controllers;

[Route("Product")]
public class ProductController : Controller
{
    [Route("Index")]
    [Route("")]

    public IActionResult SpecialsOffer()
    {

        ViewBag.SideBar = "a";
        return View();
    }
}
