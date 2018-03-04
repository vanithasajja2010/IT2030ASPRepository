using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EnrollmentApplication.Models
{
    public class Student
    {
        public virtual int Studentid { get; set; }
        public virtual string Studentlastname { get; set; }
        public virtual string Studentfirstname { get; set; }
    }
}