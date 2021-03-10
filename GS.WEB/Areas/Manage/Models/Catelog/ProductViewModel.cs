using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GS.WEB.Areas.Manage.Models.Catelog
{
    public class ProductViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string PrimaryImage { get; set; }
        public string Image1 { get; set; }
        public string Image2 { get; set; }
        public string Image3 { get; set; }
        public string Image4 { get; set; }
        public IFormFile PrimaryImageFile { get; set; }
        public IFormFile Image1File { get; set; }
        public IFormFile Image2File { get; set; }
        public IFormFile Image3File { get; set; }
        public IFormFile Image4File { get; set; }
        public long Price { get; set; }
        public int? ModelId { get; set; }
        public string   ModelName { get; set; }
        public int? CategoryId { get; set; }
        public int? SubCategoryId { get; set; }
        public string CategoryName { get; set; }
        public int? OperationStyleId { get; set; }
        public string OperationStyleName { get; set; }
        public IFormFile DocumentationFile1File { get; set; }
        public IFormFile DocumentationFile2File { get; set; }
        public string DocumentationFile1 { get; set; }
        public string DocumentationFile2 { get; set; }
        public string TechnicalSpec { get;  set; }
    }
}
