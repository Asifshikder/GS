using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GS.WEB.Models.ViewModel
{
    public class CantactViewModel
    {
        public int Id { get; set; }
        public string Subject { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Description { get; set; }
        public int ContactReasonId { get; set; }
        public string ContactReason { get; set; }
        public string Attachment { get; set; }//file 
        public IFormFile AttachmentFile { get; set; }//file 
    }
}
