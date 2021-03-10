using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GS.WEB.Areas.Manage.Models.Catelog
{
    public class SurfaceTypeViewModel
    {
        public int Id { get; set; }
        public IFormFile SurfaceLogoFile { get; set; }
        public string SurfaceTypeName { get; set; }
        public string SurfaceLogo { get; set; }
    }
}
