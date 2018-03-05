using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace EnrollmentApplication.Models
{
    public class Student
    {
        [Display(Name = "Student ID")]
        public virtual int Studentid { get; set; }

        [Display(Name = "Last Name")]
        [Required(ErrorMessage = "Last Name cannot be blank")]
        [StringLength(50)]
        public virtual string Studentlastname { get; set; }

        [Display(Name = "First Name")]
        [Required(ErrorMessage = "First Name cannot be blank")]
        [StringLength(50)]
        public virtual string Studentfirstname { get; set; }
    }
}