using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using DataAnnotationsExtensions;


namespace MVCEventBriteApp.Models
{
    public class Event
    {
        public virtual int EventId { get; set; }
        public virtual int EventTypeId { get; set; }

        [Display(Name = "Event Title")]
        [StringLength(50)]
        public virtual string EventTitle { get; set; }

        [Display(Name = "Event Description")]
        [StringLength(150)]
        public virtual string EventDescription { get; set; }

        
        [Display(Name = "Event Start Date")]
        [DataType(DataType.Date)]
        //[DisplayFormat(DataFormatString = "{0:d}")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MM/dd/yyyy}")]
        public virtual DateTime EventStartDate { get; set; }


        [Display(Name = "Event Start Time")]
        public virtual TimeSpan EventStartTime { get; set; }

        [Display(Name = "Event End Date")]      
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MM/dd/yyyy}")]
        public virtual DateTime EventEndDate { get; set; }

        [Display(Name = "Event End Time")]
        public virtual TimeSpan EventEndTime { get; set; }

        [Display(Name = "Event Location")]
        public virtual string EventLocation { get; set; }

        [Display(Name = "Event Type")]
        public virtual EventType EventType { get; set; }

        [Display(Name = "Organizer Name")]
        public virtual string OrganizerName { get; set; }

        [Display(Name = "Organizer Contact Info")]
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$")]
        public virtual string OrganizerContactInfo { get; set; }

        [Display(Name = "Max Tickets")]
        [Range(1, 100, ErrorMessage = "Max Tickets Allowed is 100" )]
        public virtual int MaxTickets { get; set; }

        [Display(Name = "Available Tickets")]
        [Range(1, 100, ErrorMessage = "At least 1 ticket needs to be available")]
        public virtual int AvailableTickets { get; set; }
    }
}