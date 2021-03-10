using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GS.WEB.Areas.Manage.Models.Shop
{
    public class StoreEmployeeVM
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Designation { get; set; }
        public string EmployeeImage { get; set; }
        public IFormFile EmployeImageefile { get; set; }
        public int? StoreId { get; set; }
        public string StoreName { get; set; }
    }
}
