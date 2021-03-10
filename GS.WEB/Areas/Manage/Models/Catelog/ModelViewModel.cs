using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GS.WEB.Areas.Manage.Models.Catelog
{
    public class ModelViewModel
    {
        public int Id { get; set; }
        public IFormFile ModelLogoFile { get; set; }
        public string ModelLogo { get; set; }
        public string ModelName { get; set; }
    }
}
