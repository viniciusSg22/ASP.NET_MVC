using Microsoft.AspNetCore.Mvc;
using MVC.Services;

namespace MVC.Controllers
{
    public class SellersController : Controller
    {
        private readonly SellerService _sellerService;

        public SellersController(SellerService sellerService)
        {
            _sellerService = sellerService;
        }

        public IActionResult Index()
        {
            var result = _sellerService.FindAll();
            return View(result);
        }
    }
}
