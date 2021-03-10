using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GS.WEB.Areas.Manage.Models.CMS
{
    public class MainPageViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string PrimaryImage { get; set; }
        public IFormFile PrimaryImageFile { get; set; }
    }
}
