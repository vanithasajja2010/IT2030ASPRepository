using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;


namespace EnrollmentApplication.Models
{
    public class Enrollment
    {
        [Display(Name = "Enrollment Id")]
        public virtual int EnrollmentId { get; set; }

        [Display(Name = "Student id")]
        public virtual int Studentid { get; set; }

        [Display(Name = "Course id")]
        public virtual int Courseid { get; set; }

        [Required(ErrorMessage = "Grade cannot be blank")]
        [RegularExpression(@"[A-F]")]
        public virtual string Grade { get; set; }

        public virtual Student Student { get; set; }

        public virtual Course Course { get; set; }

        public virtual bool IsActive { get; set; }

        [Display(Name = "Assigned Campus")]
        [Required(ErrorMessage = "Campus cannot be blank")]
        public virtual string AssignedCampus { get; set; }

        [Display(Name = "Enrolled in Semester")]
        [Required(ErrorMessage = "Enrollment semester cannot be blank")]
        public virtual string EnrollmentSemester { get; set; }

        [Required(ErrorMessage = "Enrollment year cannot be blank")]
        public virtual int EnrollmentYear { get; set; }
    }
}