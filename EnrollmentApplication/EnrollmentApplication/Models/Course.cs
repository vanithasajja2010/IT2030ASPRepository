﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EnrollmentApplication.Models
{
    public class Course
    {
        public virtual int Courseid { get; set; }
        public virtual string Coursetitle { get; set; }
        public virtual string Coursedescription { get; set; }
        public virtual decimal Coursecredits { get; set; }
    }
}