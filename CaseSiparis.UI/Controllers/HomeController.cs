using CaseSiparis.BusinessLayer.Concrete;
using CaseSiparis.DataAccesLayer.EntityFramework;
using CaseSiparis.DataEntity;
using CaseSiparis.DataEntity.Concrete;
using CaseSiparis.UI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace CaseSiparis.UI.Controllers
{
    public class HomeController : Controller
    {
        ProductManager productManager = new ProductManager(new EfProductDal());
        CompanyManager companyManager = new CompanyManager(new EfCompanyDal());
        OrderManager orderManager = new OrderManager(new EfOrderDal());
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            List<SelectListItem> valueCompany = (from category in companyManager.List()
                                                  select new SelectListItem
                                                  {
                                                      Text = category.CompanyName,
                                                      Value = category.CompanyID.ToString(),
                                                  }).ToList();
            ViewBag.valueCompany = valueCompany;

            var products = productManager.List();
            ViewBag.products = products;
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult AddOrder(Product product)
        {
            productManager.Add(product);
            return RedirectToAction("Index");
        }


        public PartialViewResult OrderList()
        {
            var products = productManager.List();
            return PartialView(products);
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult AddCompany(Company company)
        {
            companyManager.Add(company);
            return RedirectToAction("Index");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
