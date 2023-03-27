using FlowerShop.Models.Interface;
using FlowerShop.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Demosession3_MVC.Controllers;
[Route("Home")]
public class HomeController : Controller
{
    private readonly IProductService _productService;

    public HomeController(IProductService productService)
    {
        _productService = productService;
    }

    [Route("Index")]
    [Route("")]
    [Route("~/")]

    public IActionResult Index()
    {
        ViewBag.Title = "Home";
        return View(new HomeData()
        {
            Products_Featured = _productService.GetProductsDesFeatured(2),
            Products_News = _productService.GetProductsDes(3)
        });
    }
}
