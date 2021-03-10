
using GS.DATA.Entities.CMS;
using GS.SERVICE.Interface.CMS;
using GS.WEB.Models.Handler;
using GS.WEB.Models.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GS.WEB.Controllers
{
    public class ContactController : Controller
    {
        private IContactReasonService contactReasonService;
        private IContactService contactService;
        private IFileHandler fileHandler;

        public ContactController(IContactReasonService contactReasonService, IContactService contactService, IFileHandler fileHandler)
        {
            this.contactReasonService = contactReasonService;
            this.contactService = contactService;
            this.fileHandler = fileHandler;
        }
        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.reasons = new SelectList(contactReasonService.AllAsIEnumerable().Select(s => new { Id = s.Id, Name = s.Name }), "Id", "Name");
            return View();
        }
        [HttpPost]
        public IActionResult CreateNew(CantactViewModel model)
        {
            if (model.AttachmentFile != null)
            {
                model.Attachment = fileHandler.UploadFile("ContactAttachments", model.AttachmentFile);
            }
            Contact contact = new Contact();
            contact.FullName = model.FullName;
            contact.Subject = model.Subject;
            contact.Email = model.Email;
            contact.PhoneNumber = model.PhoneNumber;
            contact.Description = model.Description;
            contact.ContactReasonId = model.ContactReasonId;
            contact.Attachment = model.Attachment;
            contactService.InsertEntity(contact);
            return Redirect("/Contact/Success?id=" + contact.Id + "");
        }
        [HttpGet]
        public IActionResult Success(int id)
        {
            ViewBag.message = "Thank you for your message! We will be back as soon as possible!";
            if (id != 0)
            {
                ViewBag.message = "Thank you for your message! We will be back as soon as possible!"; 

            }
            else
            {
                ViewBag.message = "Something went wrong. Please contact with administration!";
            }
            return View();
        }
    }
}
