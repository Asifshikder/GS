using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GS.WEB.Areas.Manage.Models.Catelog
{
    public class ProductInstallViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string IconImage { get; set; }
        public IFormFile IconImageFile { get; set; }
        public long Price { get; set; }
    }
}
