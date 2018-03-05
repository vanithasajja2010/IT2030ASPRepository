using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;


namespace EnrollmentApplication.Models
{
    public class Course
    {
        [Display(Name = "Course ID")]
        public virtual int Courseid { get; set; }

        [Display(Name = "Course Title")]
        [Required(ErrorMessage = "Course title cannot be blank")]
        [StringLength(150)]
        public virtual string Coursetitle { get; set; }

        [Display(Name = "Description")]
        public virtual string Coursedescription { get; set; }

        [Display(Name = "Number of credits")]
        [Required(ErrorMessage = "Credits cannot be blank")]
        [Range(1, 4)]
        public virtual decimal Coursecredits { get; set; }
    }
}