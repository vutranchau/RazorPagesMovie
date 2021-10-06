using System;
using System.ComponentModel.DataAnnotations;

namespace RazorPagesMovie.Models
{
    public class Employee{
        [Key]
        public int EmployeeID { get; set; }
        public string EmployeeName { get; set; }
    }
}