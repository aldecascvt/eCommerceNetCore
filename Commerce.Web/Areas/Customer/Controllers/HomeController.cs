using Commerce.DataAccess.Repository.IRepository;
using Commerce.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Commerce.Web.Areas.Customer.Controllers
{
    [Area("Customer")]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        readonly IUnitOfWork _unitOfWork;

        public HomeController(ILogger<HomeController> logger,IUnitOfWork unitOfWork)
        {
            _logger = logger;
            _unitOfWork = unitOfWork;
        }

        public IActionResult Index()
        {
            var productList = _unitOfWork.Product.GetAll(includeProperties:"Category,CoverType");
            return View(productList);
        }
        public IActionResult Details(int productId)
        {
            ShoppingCart cartObj = new()
            {
                ProductId = productId,
                Product = _unitOfWork.Product.GetFirstOrDefault(x => x.Id == productId, includeProperties: "Category,CoverType"),
                Count = 1
            };

            return View(cartObj);
        }


        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}