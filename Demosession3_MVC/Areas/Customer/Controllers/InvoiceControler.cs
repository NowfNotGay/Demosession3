using Microsoft.AspNetCore.Mvc;

namespace Demosession3_MVC.Areas.Customer.Controllers;
[Area("customer")]
[Route("customer/invoice")]

public class InvoiceControler : Controller
{
    [Route("")]
    [Route("index")]
    public IActionResult Index()
    {
        return View();
    }
}
