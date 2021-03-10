using GS.DATA.Entities.CustomPort;
using GS.SERVICE.Interface.CustomPort;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GS.WEB.Controllers
{
    public class CustomGarageportController : Controller
    {
        private IPatternPriceRoleService patternPriceRoleService;
        private IColorPriceRoleService colorPriceRoleService;
        private ISurfaceLayerPriceRoleService surfaceLayerPriceRoleService;
        private IOperationStylePriceRoleService operationStylePriceRoleService;
        private IBaseGaragePortService baseGaragePortService;
        private ISizePriceRoleService sizePriceRoleService;

        public CustomGarageportController(IPatternPriceRoleService patternPriceRoleService,
            IColorPriceRoleService colorPriceRoleService,
            ISurfaceLayerPriceRoleService surfaceLayerPriceRoleService,
            IOperationStylePriceRoleService operationStylePriceRoleService,
            IBaseGaragePortService baseGaragePortService,
            ISizePriceRoleService sizePriceRoleService
            )
        {
            this.patternPriceRoleService = patternPriceRoleService;
            this.colorPriceRoleService = colorPriceRoleService;
            this.surfaceLayerPriceRoleService = surfaceLayerPriceRoleService;
            this.operationStylePriceRoleService = operationStylePriceRoleService;
            this.baseGaragePortService = baseGaragePortService;
            this.sizePriceRoleService = sizePriceRoleService;
        }
        [HttpGet]
        public IActionResult Index()
        {
            var simplepattern = patternPriceRoleService.GetSmallPattern();
            ViewBag.patternlist = new SelectList(patternPriceRoleService.AllAsIEnumerable(), "Id", "Name");
            ViewBag.colorlist = new SelectList(colorPriceRoleService.AllAsIEnumerable(), "Id", "Name");
            ViewBag.surfacelayerlist = new SelectList(surfaceLayerPriceRoleService.AllAsIEnumerable().Where(s=>s.PatternPriceRoleId==simplepattern.Id), "Id", "Name");
            ViewBag.operationstylelist = new SelectList(operationStylePriceRoleService.AllAsIEnumerable(), "Id", "Name");
            BaseGaragePort baseGaragePort = baseGaragePortService.AllAsList().FirstOrDefault();
            return View(baseGaragePort);
        }

       

        [HttpGet]
        public JsonResult GetSurfaceLayerRole(int? patternrole)
        {
            if (patternrole != null)
            {
                ViewBag.surfacelayerlist = new SelectList(surfaceLayerPriceRoleService.AllAsIEnumerable().Where(a => a.PatternPriceRoleId == patternrole).ToList(), "Id", "Name");
            }
            else
            {
                ViewBag.surfacelayerlist = new SelectList(surfaceLayerPriceRoleService.AllAsIEnumerable().ToList(), "Id", "Name");
            }
            return Json(ViewBag.surfacelayerlist);

        }

        [HttpGet]
        public JsonResult CalculatePrice(long width,long height, int? pattern,int? color, int? surfacelayer, int? operation)
        {
            long data = 0;
            long patternincrease = 0;
            long colorincrease = 0;
            long surfaceincrease = 0;
            long operationincrease = 0;
            if (pattern != null)
            {
                var patterndb = patternPriceRoleService.GetById(pattern.Value);
                patternincrease = patterndb.PriceIncrease.Value;
            }
            if (color != null)
            {
                var colordb = colorPriceRoleService.GetById(color.Value);
                colorincrease = colordb.PriceIncrease.Value;
            }
            if (surfacelayer != null)
            {
                var surfacedb = surfaceLayerPriceRoleService.GetById(surfacelayer.Value);
                surfaceincrease = surfacedb.PriceIncrease.Value;
            }
            if (operation != null)
            {
                var operationdb = operationStylePriceRoleService.GetById(operation.Value);
                operationincrease = operationdb.PriceIncrease.Value;
            }
            var baseporter = baseGaragePortService.AllAsList().FirstOrDefault();
            long sizeprice = GetSizeRolePrice(width, height);
            long baseprice = baseporter.BasePrice.Value;
            data = baseprice + patternincrease + colorincrease + surfaceincrease + operationincrease + sizeprice;
            return Json(data);

        }

        private long GetSizeRolePrice(long width, long height)
        {
            try
            {
                long priceval = 0;
                var sizerole = sizePriceRoleService.AllAsList().Where(s => s.FromWidth >= width && s.ToHeight <= width && s.FromHeight >= height && s.ToHeight <= height).FirstOrDefault();
                if (sizerole != null)
                {
                    priceval = sizerole.PriceIncrease.Value;
                }
                return priceval;
            }
            catch (Exception ex)
            {

                throw;
            }
        }
    }
}
