using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Barovi.Models
{
    public class Bars
    {
        [Key]
        public string Name { get; set; }
        [Display(Name = "Image")]
        public string Image { get; set; }
        public string Hours { get; set; }
        public string Location { get; set; }
        public string Phone { get; set; }
        public float Rating { get; set; }
        

    }
}