using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Class1
    {
        [Key]
        public int EmpId { get; set; }
        public String Name { get; set; }
        public int Salary { get; set; }
    }
}