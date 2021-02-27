using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EmployeeMVC.Models
{
    public class mvcEmployee
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="Name is reqired")]
        public string Name { get; set; }
        public string Position { get; set; }
        public string Salary { get; set; }
    }
}