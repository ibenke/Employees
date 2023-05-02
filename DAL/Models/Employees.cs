using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace DAL.Models
{
    public partial class Employees
    {
        [Key]
        [Column("emp_no")]
        public int EmpNo { get; set; }
        [Column("birth_date", TypeName = "date")]
        public DateTime? BirthDate { get; set; }
        [Column("first_name")]
        [StringLength(100)]
        public string FirstName { get; set; }
        [Column("last_name")]
        [StringLength(100)]
        public string LastName { get; set; }
        [Column("gender")]
        [StringLength(1)]
        public string Gender { get; set; }
        [Column("hire_date", TypeName = "date")]
        public DateTime? HireDate { get; set; }
    }
}
