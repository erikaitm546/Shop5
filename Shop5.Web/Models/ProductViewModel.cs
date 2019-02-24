using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop5.Web.Models
{
    using System.ComponentModel.DataAnnotations;
    using Data.Entities;
    using Microsoft.AspNetCore.Http;

    public class ProductViewModel : Product
    {
        [Display(Name = "Image")]
        public IFormFile ImageFile { get; set; }
    }


}
