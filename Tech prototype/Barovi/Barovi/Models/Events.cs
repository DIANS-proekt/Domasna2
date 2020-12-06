using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Barovi.Models
{
    public class Events
    {
        [Key]
        public string Name { get; set; }
        [Display(Name = "Image")]
        public string Image { get; set; }
        public string Location { get; set; }
        public int Price { get; set; }
        public string Age { get; set; }
        
    }
}