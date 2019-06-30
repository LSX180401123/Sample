using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CourseManager.Models
{
    public class SideBars
    {
        [Key]
        public int Id { get; set; }
        [Display(Name="名称")]
        public string Name { get; set; }
        public string Controller { get; set; }
        public string Action { get; set; }
        public int order { get; set; }
    }
}