using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GS.WEB.Areas.Manage.Models.Shop
{
    public class StoreVM
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string StoreViewImage { get; set; }
        public IFormFile StoreViewImageFile { get; set; }
        public string MapIFrame { get; set; }
        public string StoreOnTime { get; set; }
        public string SeoMETA { get; set; }
        public string SeoMETAEnglish { get; set; }
    }
}
