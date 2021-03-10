using GS.DATA.Entities.CustomPort;
using GS.SERVICE.Interface.CustomPort;
using GS.WEB.Areas.Manage.Models.CustomPortar;
using GS.WEB.Models.Handler;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace GS.WEB.Areas.Manage.Controllers
{
    [Area("Manage")]
    [Authorize]

    public class BaseGaragePortController : Controller
    {
        private IBaseGaragePortService baseGaragePortService;
        private IFileHandler fileHandler;
        private IWebHostEnvironment webHost;
        private string webrootpath;

        public BaseGaragePortController(IBaseGaragePortService baseGaragePortService, IFileHandler fileHandler, IWebHostEnvironment webHost)
        {
            this.baseGaragePortService = baseGaragePortService;
            this.fileHandler = fileHandler;
            this.webHost = webHost;
        }
        [HttpGet]
        public IActionResult Index()
        {
            BaseGaragePort baseGaragePort = baseGaragePortService.AllAsList().FirstOrDefault();
            return View(baseGaragePort);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(BaseGaragePortViewModel model)
        {
            if (model.DocumentFileFile != null)
            {
                var file = model.DocumentFileFile;
                var foldername = "Anpassa"; string webrootpath = webHost.WebRootPath;

                var filename = model.DocumentFileFile.FileName;
                string path = Path.Combine(webrootpath, foldername, filename);
                using (var fileStream = new FileStream(path, FileMode.Create))
                {
                    file.CopyTo(fileStream);
                }
                string pathName = Path.Combine(foldername, filename);
                string fileUrl = "~/" + foldername + "/" + filename;
                model.DocumentFile = fileUrl;
            }
            if (model.DocumentFile1File != null)
            {
                var file = model.DocumentFile1File;
                var foldername = "Anpassa"; string webrootpath = webHost.WebRootPath;

                var filename = model.DocumentFile1File.FileName;
                string path = Path.Combine(webrootpath, foldername, filename);
                using (var fileStream = new FileStream(path, FileMode.Create))
                {
                    file.CopyTo(fileStream);
                }
                string pathName = Path.Combine(foldername, filename);
                string fileUrl = "~/" + foldername + "/" + filename;
                model.DocumentFile1 = fileUrl;
            }
            if (model.BaseImageFile != null)
            {
                model.BaseImage = fileHandler.UploadFile("Anpassa", model.BaseImageFile);
            }
            if (model.Image1File != null)
            {
                model.Image1 = fileHandler.UploadFile("Anpassa", model.Image1File);
            }
            if (model.Image2File != null)
            {
                model.Image2 = fileHandler.UploadFile("Anpassa", model.Image2File);
            }

            BaseGaragePort port = new BaseGaragePort();
            port.Title = model.Title;
            port.Description = model.Description;
            port.DocumentFile = model.DocumentFile;
            port.DocumentFile1 = model.DocumentFile1;
            port.Instruction = model.Instruction;
            port.TechnicalSpecification = model.TechnicalSpecification;
            port.BaseImage = model.BaseImage;
            port.Image1 = model.Image1;
            port.Image2 = model.Image2;
            port.BasePrice = model.BasePrice;
            baseGaragePortService.InsertEntity(port);
            return Redirect("/Manage/BaseGaragePort/Index");
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            BaseGaragePortViewModel port = new BaseGaragePortViewModel();
            BaseGaragePort model = baseGaragePortService.GetById(id);
            port.Id = model.Id;
            port.Title = model.Title;
            port.Description = model.Description;
            port.DocumentFile = model.DocumentFile;
            port.DocumentFile1 = model.DocumentFile1;
            port.Instruction = model.Instruction;
            port.TechnicalSpecification = model.TechnicalSpecification;
            port.BaseImage = model.BaseImage;
            port.Image1 = model.Image1;
            port.Image2 = model.Image2;
            port.BasePrice = model.BasePrice;
            return View(port);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Update(BaseGaragePortViewModel model)
        {
            if (model.DocumentFileFile != null)
            {
                var file = model.DocumentFileFile;
                if (model.DocumentFile != null)
                {
                    string dbpath = model.DocumentFile.Replace("~/", "").ToString();
                    string uppath = dbpath.Replace("/", "\\").ToString();
                    string fullpath = webHost.WebRootPath + "\\" + uppath;
                    System.IO.File.Delete(fullpath);
                    GC.Collect();
                    GC.WaitForPendingFinalizers();
                }

                var foldername = "Anpassa";
                string webrootpath = webHost.WebRootPath;
                var filename = model.DocumentFileFile.FileName;
                string path = Path.Combine(webrootpath, foldername, filename);
                using (var fileStream = new FileStream(path, FileMode.Create))
                {
                    file.CopyTo(fileStream);
                }
                string pathName = Path.Combine(foldername, filename);
                string fileUrl = "~/" + foldername + "/" + filename;
                model.DocumentFile = fileUrl;
            }
            if (model.DocumentFile1File != null)
            {
                var file = model.DocumentFile1File;
                if (model.DocumentFile1 != null)
                {
                    string dbpath = model.DocumentFile1.Replace("~/", "").ToString();
                    string uppath = dbpath.Replace("/", "\\").ToString();
                    string fullpath = webHost.WebRootPath + "\\" + uppath;
                    System.IO.File.Delete(fullpath);
                    GC.Collect();
                    GC.WaitForPendingFinalizers();
                }

                var foldername = "Anpassa";
                string webrootpath = webHost.WebRootPath;

                var filename = model.DocumentFile1File.FileName;
                string path = Path.Combine(webrootpath, foldername, filename);
                using (var fileStream = new FileStream(path, FileMode.Create))
                {
                    file.CopyTo(fileStream);
                }
                string pathName = Path.Combine(foldername, filename);
                string fileUrl = "~/" + foldername + "/" + filename;
                model.DocumentFile1 = fileUrl;
            }
            if (model.BaseImageFile != null)
            {
                model.BaseImage = fileHandler.UpdateFile(model.BaseImage, "Anpassa", model.BaseImageFile);
            }
            if (model.Image1File != null)
            {
                model.Image1 = fileHandler.UpdateFile(model.Image1, "Anpassa", model.Image1File);
            }
            if (model.Image2File != null)
            {
                model.Image2 = fileHandler.UpdateFile(model.Image2, "Anpassa", model.Image2File);
            }

            BaseGaragePort port = new BaseGaragePort();
            port.Id = model.Id;
            port.Title = model.Title;
            port.Description = model.Description;
            port.DocumentFile = model.DocumentFile;
            port.DocumentFile1 = model.DocumentFile1;
            port.Instruction = model.Instruction;
            port.TechnicalSpecification = model.TechnicalSpecification;
            port.BaseImage = model.BaseImage;
            port.Image1 = model.Image1;
            port.Image2 = model.Image2;
            port.BasePrice = model.BasePrice;
            baseGaragePortService.UpdateEntity(port);
            return Redirect("/Manage/BaseGaragePort/Index");
        }
    }
}
