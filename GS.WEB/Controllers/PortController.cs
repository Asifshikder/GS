using GS.DATA.Entities.Catelog;
using GS.SERVICE.Interface.Catelog;
using GS.WEB.Models;
using GS.WEB.Models.ViewModel;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GS.WEB.Controllers
{
    public class PortController : Controller
    {
        private IProductService productService;

        public PortController(IProductService productService)
        {
            this.productService = productService;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public async Task<IActionResult> Portar(int pagenumber =1)
        {
            var dorlist = productService.AllAsIQueryable().Where(s => s.CategoryId == 1);
           
            return View(await PaginatedList<Product>.CreateAsync(dorlist, pagenumber,5));
        }
        [HttpGet]
        public IActionResult SinglePort(int id)
        {
            var prod = productService.AllAsList().Where(s => s.Id == id).FirstOrDefault();
           
            return View(prod);
        }
    }
}
