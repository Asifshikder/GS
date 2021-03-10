using GS.DATA.Entities.CMS;
using GS.SERVICE.Interface.CMS;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GS.WEB.Areas.Manage.Controllers
{
    [Area("Manage")]
    public class ContactReasonController : Controller
    {
        private IContactReasonService contactReasonService;

        public ContactReasonController(IContactReasonService contactReasonService)
        {
            this.contactReasonService = contactReasonService;
        }
        [HttpGet]
        public IActionResult Index()
        {
            var entityList = contactReasonService.AllAsIEnumerable();
            return View(entityList);
        }
        [HttpGet]
        public IActionResult Create()
        {
            ContactReason ContactReason = new ContactReason();
            return View(ContactReason);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(ContactReason ContactReason)
        {
            contactReasonService.InsertEntity(ContactReason);
            return Redirect("/Manage/ContactReason/Index");
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            ContactReason ContactReason = contactReasonService.GetById(id);
            return View(ContactReason);
        }
        [HttpPost]
        [Route("/Manage/ContactReason/Update")]
        [AutoValidateAntiforgeryToken]
        public IActionResult Update(ContactReason ContactReason)
        {
            contactReasonService.UpdateEntity(ContactReason);
            return Redirect("/Manage/ContactReason/Index");
        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            ContactReason ContactReason = contactReasonService.GetById(id);
            return View(ContactReason);
        }
        [HttpPost]
        [Route("/Manage/ContactReason/DeleteConfirm")]
        [AutoValidateAntiforgeryToken]
        public IActionResult DeleteConfirm(ContactReason ContactReason)
        {
            contactReasonService.DeleteEntity(ContactReason);
            return Redirect("/Manage/ContactReason/Index");
        }
    }
}
