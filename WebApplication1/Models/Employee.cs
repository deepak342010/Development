using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WebApplication1.Models
{
    public partial class Employee
    {
        public int Id { get; set; }
        public string EmpName { get; set; }
        public string Address { get; set; }
    }
}
