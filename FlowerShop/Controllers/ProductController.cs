using FlowerShop.Models.Interface;
using Microsoft.AspNetCore.Mvc;

namespace FlowerShop.Controllers;
[Route("product")]
public class ProductController : Controller
{
	private readonly IProductService _productService;

    public ProductController(IProductService productService)
    {
        _productService = productService;
    }
    [Route("sp")]
    public IActionResult SP()
	{
		return View();
	}

    [Route("Flower")]
    public IActionResult Flower()
	{
		return View();
	}

    [Route("Price")]
    public IActionResult Price()
	{
		return View();
	}
    [Route("Details")]
    public IActionResult Details(int id)
    {
        return View(_productService.GetProductById(id));
    }
}
