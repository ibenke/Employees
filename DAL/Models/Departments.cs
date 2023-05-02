using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace DAL.Models
{
    public partial class Departments
    {
        [Key]
        [Column("dept_no")]
        [StringLength(4)]
        public string DeptNo { get; set; }
        [Column("dept_name")]
        [StringLength(50)]
        public string DeptName { get; set; }
    }
}
