﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EnrollmentApplication.Models
{
    public class Enrollment
    {
        public virtual int EnrollmentId { get; set; }
        public virtual int Studentid { get; set; }
        public virtual int Courseid { get; set; }
        public virtual string Grade { get; set; }
        public virtual Student Student { get; set; }
        public virtual Course Course { get; set; }
    }
}