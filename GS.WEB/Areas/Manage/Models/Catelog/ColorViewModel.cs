using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GS.WEB.Areas.Manage.Models.Catelog
{
    public class ColorViewModel
    {
        public int Id { get; set; }
        public IFormFile SampleImageFile { get; set; }
        public string ColorSamplmage { get; set; }
        public string ColorName { get; set; }
    }
}
