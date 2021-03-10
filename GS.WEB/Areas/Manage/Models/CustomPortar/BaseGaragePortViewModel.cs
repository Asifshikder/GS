using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GS.WEB.Areas.Manage.Models.CustomPortar
{
    public class BaseGaragePortViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string DocumentFile { get; set; }
        public IFormFile DocumentFileFile { get; set; }
        public string DocumentFile1 { get; set; }
        public IFormFile DocumentFile1File { get; set; }
        public string Instruction { get; set; }
        public string TechnicalSpecification { get; set; }
        public string BaseImage { get; set; }
        public IFormFile BaseImageFile { get; set; }
        public string Image1 { get; set; }
        public IFormFile Image1File { get; set; }
        public string Image2 { get; set; }
        public IFormFile Image2File { get; set; }
        public long? BasePrice { get; set; }
    }
}
