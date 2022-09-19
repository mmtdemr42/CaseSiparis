using CaseSiparis.BusinessLayer.Concrete;
using CaseSiparis.BusinessLayer.FluentValidation;
using CaseSiparis.DataAccesLayer.EntityFramework;
using CaseSiparis.DataEntity;
using CaseSiparis.DataEntity.Concrete;
using CaseSiparis.UI.Models;
using FluentValidation.Results;
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

        ProductValidation productValidation = new ProductValidation();
        CompanyValidation companyValidation = new CompanyValidation();

        ValidationResult result;
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
        public IActionResult Index(Product product)
        {
            result = productValidation.Validate(product);

            if (result.IsValid)
            {
                productManager.Add(product);
                return RedirectToAction("Index");
            }
            else
            {
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(error.PropertyName, error.ErrorMessage);
                }
            }
            var products = productManager.List();
            ViewBag.products = products;
            List<SelectListItem> valueCompany = (from category in companyManager.List()
                                                 select new SelectListItem
                                                 {
                                                     Text = category.CompanyName,
                                                     Value = category.CompanyID.ToString(),
                                                 }).ToList();
            ViewBag.valueCompany = valueCompany;
            return View(product);
        }


        
        public IActionResult Privacy()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Privacy(Company company)
        {
            result = companyValidation.Validate(company);

            if (result.IsValid)
            {
                companyManager.Add(company);
                return RedirectToAction("Index");
            }
            else
            {
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(error.PropertyName, error.ErrorMessage);
                }
            }
            
            return View(company);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
