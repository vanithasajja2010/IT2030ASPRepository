using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MVCEventBriteApp.Models
{
    public class EventType
    {
        public virtual int EventTypeId { get; set; }

        [Display(Name = "Event Type")]
        public virtual string Type { get; set; }
    }
}