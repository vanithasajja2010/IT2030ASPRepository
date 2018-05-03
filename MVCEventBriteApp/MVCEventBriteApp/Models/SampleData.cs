﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace MVCEventBriteApp.Models
{
    public class SampleData : DropCreateDatabaseAlways<EventBriteDB>
    {
        protected override void Seed(EventBriteDB context)
        {
            var eventType = new List<EventType>
            {
                new EventType { Type = "Conference" },
                new EventType { Type = "Dinner or Gala" },
                new EventType { Type = "Festival/Fair" },
                new EventType { Type = "Game/Competition" },
                new EventType { Type = "Meeting/Networking Event" },
                new EventType { Type = "Workshop" },
                new EventType { Type = "Concert" },
                new EventType { Type = "Dance" },
                new EventType { Type = "Fundraiser" },
                new EventType { Type = "Social Gathering" }
            };

            new List<Event>
            {
                new Event { EventType = eventType.Single(e => e.Type == "Dance"), EventTitle = "Mystic India Show", EventDescription = "Broadway Performance", EventStartDate = new DateTime(2018, 05, 25), EventStartTime = new TimeSpan(06, 00, 00), EventEndDate = new DateTime(2018, 05, 25), EventEndTime = new TimeSpan(08, 00, 00), EventLocation = "Cleveland", OrganizerName = "AIPNO", OrganizerContactInfo = "216-345-8888", MaxTickets = 2000, AvailableTickets = 500 },
                new Event { EventType = eventType.Single(e => e.Type == "Concert"), EventTitle = "Bruno Mars Concert", EventDescription = "Music Performace", EventStartDate = new DateTime(2018, 04, 25), EventStartTime = new TimeSpan(07, 00, 00), EventEndDate = new DateTime(2018, 05, 25), EventEndTime = new TimeSpan(12, 00, 00), EventLocation = "Cleveland", OrganizerName = "MNP Organization", OrganizerContactInfo = "216-367-6757", MaxTickets = 1000, AvailableTickets = 200 },
                new Event { EventType = eventType.Single(e => e.Type == "Workshop"), EventTitle = "Toast Masters Workshop", EventDescription = "Speech Classes", EventStartDate = new DateTime(2018, 04, 30), EventStartTime = new TimeSpan(04, 00, 00), EventEndDate = new DateTime(2018, 05, 25), EventEndTime = new TimeSpan(06, 00, 00), EventLocation = "Cleveland", OrganizerName = "Toast Masters", OrganizerContactInfo = "216-365-4323", MaxTickets = 100, AvailableTickets = 2 },
                new Event { EventType = eventType.Single(e => e.Type == "Festival/Fair"), EventTitle = "Spring Fruit and Veggie Fun Festival", EventDescription = "Fruit and Vegiie Festival", EventStartDate = new DateTime(2018,04,18), EventStartTime = new TimeSpan(09,00,00), EventEndDate = new DateTime(2018,04,18), EventEndTime = new TimeSpan(06,00,00), EventLocation = "Orange", OrganizerName = "Heinen's", OrganizerContactInfo = "216-456-8897", MaxTickets = 200 , AvailableTickets = 200 },
                new Event { EventType = eventType.Single(e => e.Type == "Social Gathering"), EventTitle = "Mother's Day Celebration", EventDescription = "Mother's Day Brunch", EventStartDate = new DateTime(2018, 05, 13), EventStartTime = new TimeSpan(11, 00, 00), EventEndDate = new DateTime(2018, 05, 13), EventEndTime = new TimeSpan(03, 00, 00), EventLocation = "Solon", OrganizerName = "Solon Community Center", OrganizerContactInfo = "216-678-9800", MaxTickets = 100, AvailableTickets =20},
                new Event { EventType = eventType.Single(e => e.Type == "Dinner or Gala"), EventTitle = "Annual Scholarship and Awards Gala", EventDescription = "Academic Scholarship Event", EventStartDate = new DateTime(2018, 03, 25), EventStartTime = new TimeSpan(05, 00, 00), EventEndDate = new DateTime(2018, 03, 25), EventEndTime = new TimeSpan(07, 00, 00), EventLocation = "Beachwood", OrganizerName = "BPOY Organization", OrganizerContactInfo = "456-678-9870", MaxTickets = 100 , AvailableTickets = 50},
                new Event { EventType = eventType.Single(e => e.Type == "Social Gathering"), EventTitle = "Father's Day Celebration", EventDescription = "Father's Day Brunch", EventStartDate = new DateTime(2018, 06, 13), EventStartTime = new TimeSpan(11, 00, 00), EventEndDate = new DateTime(2018, 06, 13), EventEndTime = new TimeSpan(03, 00, 00), EventLocation = "Solon", OrganizerName = "Solon Community Center", OrganizerContactInfo = "216-678-9800", MaxTickets = 100, AvailableTickets = 100},
                new Event { EventType = eventType.Single(e => e.Type == "Dance"), EventTitle = "Arya Academy Show", EventDescription = "Arya Academy Annual Dance Performance", EventStartDate = new DateTime(2017, 05, 25), EventStartTime = new TimeSpan(06, 00, 00), EventEndDate = new DateTime(2017, 05, 25), EventEndTime = new TimeSpan(08, 00, 00), EventLocation = "Downtown", OrganizerName = "Arya Academy", OrganizerContactInfo = "216-345-8888", MaxTickets = 300, AvailableTickets = 100},
                new Event { EventType = eventType.Single(e => e.Type == "Fundraiser"), EventTitle = "AIPNO Annual Chiraag", EventDescription = "Fund Raiser Event For Cleveland Sight Center", EventStartDate = new DateTime(2018, 06, 12), EventStartTime = new TimeSpan(07, 00, 00), EventEndDate = new DateTime(2018, 06, 12), EventEndTime = new TimeSpan(12, 00, 00), EventLocation = "Downtown", OrganizerName = "AIPNO", OrganizerContactInfo = "216-367-6757", MaxTickets = 1000, AvailableTickets = 200 },
                new Event { EventType = eventType.Single(e => e.Type == "Workshop"), EventTitle = "NSF Spelling Bee Workshop", EventDescription = "Spelling Bee", EventStartDate = new DateTime(2018, 05, 30), EventStartTime = new TimeSpan(04, 00, 00), EventEndDate = new DateTime(2018, 05, 30), EventEndTime = new TimeSpan(06, 00, 00), EventLocation = "Parma Library", OrganizerName = "North South Foundation", OrganizerContactInfo = "216-325-4223", MaxTickets = 100, AvailableTickets = 2 },
                new Event { EventType = eventType.Single(e => e.Type == "Festival/Fair"), EventTitle = "Hawkfest", EventDescription = "Fall Festival", EventStartDate = new DateTime(2018,10,18), EventStartTime = new TimeSpan(09,00,00), EventEndDate = new DateTime(2018,10,18), EventEndTime = new TimeSpan(06,00,00), EventLocation = "Hawken Lyndhurst Campus", OrganizerName = "Hawken", OrganizerContactInfo = "426-678-9870", MaxTickets = 1000 , AvailableTickets = 1000 },
                new Event { EventType = eventType.Single(e => e.Type == "Social Gathering"), EventTitle = "Diwali Celebrations", EventDescription = "2018 Diwali Celebrations", EventStartDate = new DateTime(2018, 11, 13), EventStartTime = new TimeSpan(06, 00, 00), EventEndDate = new DateTime(2018, 11, 13), EventEndTime = new TimeSpan(12, 00, 00), EventLocation = "Beachwood", OrganizerName = "Indian Association", OrganizerContactInfo = "216-578-9800", MaxTickets = 500, AvailableTickets = 500},
                new Event { EventType = eventType.Single(e => e.Type == "Dinner or Gala"), EventTitle = "Annual Scholarship and Awards Gala", EventDescription = "Hawken 2018 Scholarships", EventStartDate = new DateTime(2018, 05, 25), EventStartTime = new TimeSpan(05, 00, 00), EventEndDate = new DateTime(2018, 05, 25), EventEndTime = new TimeSpan(07, 00, 00), EventLocation = "Hawken Gatesmills Campus", OrganizerName = "Hawken", OrganizerContactInfo = "426-678-9870", MaxTickets = 100 , AvailableTickets = 50},
                new Event { EventType = eventType.Single(e => e.Type == "Social Gathering"), EventTitle = "Valentines Day Celebration", EventDescription = "Valentine's Day Brunch", EventStartDate = new DateTime(2018, 02, 14), EventStartTime = new TimeSpan(11, 00, 00), EventEndDate = new DateTime(2018, 02, 14), EventEndTime = new TimeSpan(03, 00, 00), EventLocation = "Solon", OrganizerName = "Solon Community Center", OrganizerContactInfo = "216-678-9800", MaxTickets = 100, AvailableTickets = 100},
                new Event { EventType = eventType.Single(e => e.Type == "Fundraiser"), EventTitle = "Bingo Night Fundraiser", EventDescription = "Fund Raiser for Epilepsy", EventStartDate = new DateTime(2018, 02, 01), EventStartTime = new TimeSpan(06, 00, 00), EventEndDate = new DateTime(2018, 02, 01), EventEndTime = new TimeSpan(11, 00, 00), EventLocation = "Downtown", OrganizerName = "SIL", OrganizerContactInfo = "216-342-8986", MaxTickets = 500, AvailableTickets = 100 },
                new Event { EventType = eventType.Single(e => e.Type == "Conference"), EventTitle = "ACH Meeting", EventDescription = "Kidney and Hypertension Conference", EventStartDate = new DateTime(2018, 01, 06), EventStartTime = new TimeSpan(06, 00, 00), EventEndDate = new DateTime(2018, 01, 06), EventEndTime = new TimeSpan(09, 00, 00), EventLocation = "Downtown", OrganizerName = "CDC", OrganizerContactInfo = "216-345-8988", MaxTickets = 200, AvailableTickets = 10 },
                new Event { EventType = eventType.Single(e => e.Type == "Dance"), EventTitle = "School Dance", EventDescription = "Independent Schools Dance Program", EventStartDate = new DateTime(2018, 05, 30), EventStartTime = new TimeSpan(06, 00, 00), EventEndDate = new DateTime(2018, 05, 30), EventEndTime = new TimeSpan(08, 00, 00), EventLocation = "Shaker Heights", OrganizerName = "Independent Schools Organization", OrganizerContactInfo = "216-222-8888", MaxTickets = 60, AvailableTickets = 30 },
                new Event { EventType = eventType.Single(e => e.Type == "Concert"), EventTitle = "High School Concert", EventDescription = "High School Music Performance", EventStartDate = new DateTime(2018, 05, 15), EventStartTime = new TimeSpan(07, 00, 00), EventEndDate = new DateTime(2018, 05, 15), EventEndTime = new TimeSpan(12, 00, 00), EventLocation = "Parma", OrganizerName = "Birchwood School", OrganizerContactInfo = "216-357-6757", MaxTickets = 100, AvailableTickets = 20 },
                new Event { EventType = eventType.Single(e => e.Type == "Workshop"), EventTitle = "Gardening Workshop", EventDescription = "Home Depot Gardening/Outddor Workshop", EventStartDate = new DateTime(2018, 06, 30), EventStartTime = new TimeSpan(04, 00, 00), EventEndDate = new DateTime(2018, 06, 30), EventEndTime = new TimeSpan(06, 00, 00), EventLocation = "Solon", OrganizerName = "Home Depot", OrganizerContactInfo = "216-365-4353", MaxTickets = 100, AvailableTickets = 2 },
                new Event { EventType = eventType.Single(e => e.Type == "Festival/Fair"), EventTitle = "Book Fair", EventDescription = "Book Fair/Sale", EventStartDate = new DateTime(2018,05,10), EventStartTime = new TimeSpan(09,00,00), EventEndDate = new DateTime(2018,05,18), EventEndTime = new TimeSpan(06,00,00), EventLocation = "Parma", OrganizerName = "Birchwood School", OrganizerContactInfo = "216-237-8897", MaxTickets = 200 , AvailableTickets = 200 },
                new Event { EventType = eventType.Single(e => e.Type == "Social Gathering"), EventTitle = "Holi Celebrations", EventDescription = "Signature Of Solon Holi Party", EventStartDate = new DateTime(2018, 07, 13), EventStartTime = new TimeSpan(11, 00, 00), EventEndDate = new DateTime(2018, 07, 13), EventEndTime = new TimeSpan(03, 00, 00), EventLocation = "Solon", OrganizerName = "Signature of Solon", OrganizerContactInfo = "216-324-9800", MaxTickets = 200, AvailableTickets =20},
                new Event { EventType = eventType.Single(e => e.Type == "Dinner or Gala"), EventTitle = "Women of Strength", EventDescription = "Cancer Outreach Dinner", EventStartDate = new DateTime(2018, 06, 25), EventStartTime = new TimeSpan(05, 00, 00), EventEndDate = new DateTime(2018, 06, 25), EventEndTime = new TimeSpan(07, 00, 00), EventLocation = "Beachwood", OrganizerName = "Mercy Cancer Care", OrganizerContactInfo = "216-678-9870", MaxTickets = 100 , AvailableTickets = 50},
                new Event { EventType = eventType.Single(e => e.Type == "Social Gathering"), EventTitle = "Celebration of Generosity", EventDescription = "Holy Faith Church Event", EventStartDate = new DateTime(2018, 06, 13), EventStartTime = new TimeSpan(11, 00, 00), EventEndDate = new DateTime(2018, 06, 13), EventEndTime = new TimeSpan(03, 00, 00), EventLocation = "Mayfield Heights", OrganizerName = "Holy Faith Church", OrganizerContactInfo = "216-628-9800", MaxTickets = 100, AvailableTickets = 100},
                new Event { EventType = eventType.Single(e => e.Type == "Dance"), EventTitle = "Arya Academy Show", EventDescription = "Arya Academy Dance Competition", EventStartDate = new DateTime(2017, 08, 25), EventStartTime = new TimeSpan(06, 00, 00), EventEndDate = new DateTime(2017, 08, 25), EventEndTime = new TimeSpan(08, 00, 00), EventLocation = "Downtown", OrganizerName = "Arya Academy", OrganizerContactInfo = "216-345-8888", MaxTickets = 300, AvailableTickets = 100},
                new Event { EventType = eventType.Single(e => e.Type == "Fundraiser"), EventTitle = "Alzheimer's Fund Raising Event", EventDescription = "Fund Raiser Event For Alzheimer's", EventStartDate = new DateTime(2018, 06, 12), EventStartTime = new TimeSpan(07, 00, 00), EventEndDate = new DateTime(2018, 06, 12), EventEndTime = new TimeSpan(12, 00, 00), EventLocation = "Downtown", OrganizerName = "AIPCC", OrganizerContactInfo = "216-123-6757", MaxTickets = 1000, AvailableTickets = 200 },
                new Event { EventType = eventType.Single(e => e.Type == "Workshop"), EventTitle = "Creating a Healthy Neighborhood Together", EventDescription = "Cleveland City Safety Event", EventStartDate = new DateTime(2018, 05, 30), EventStartTime = new TimeSpan(04, 00, 00), EventEndDate = new DateTime(2018, 05, 30), EventEndTime = new TimeSpan(06, 00, 00), EventLocation = "Parma Library", OrganizerName = "North South Foundation", OrganizerContactInfo = "216-325-4223", MaxTickets = 100, AvailableTickets = 2 },
                new Event { EventType = eventType.Single(e => e.Type == "Festival/Fair"), EventTitle = "Solon Days", EventDescription = "Roll n Ride Event", EventStartDate = new DateTime(2018,06,18), EventStartTime = new TimeSpan(09,00,00), EventEndDate = new DateTime(2018,06,20), EventEndTime = new TimeSpan(06,00,00), EventLocation = "Solon", OrganizerName = "Metroparks", OrganizerContactInfo = "440-678-9870", MaxTickets = 3000 , AvailableTickets = 2000 },
                new Event { EventType = eventType.Single(e => e.Type == "Social Gathering"), EventTitle = "Back to School Event", EventDescription = "9th Grade Hawken Back to School Gathering", EventStartDate = new DateTime(2018, 08, 13), EventStartTime = new TimeSpan(06, 00, 00), EventEndDate = new DateTime(2018, 08, 13), EventEndTime = new TimeSpan(12, 00, 00), EventLocation = "Hawken Gatesmills Campus", OrganizerName = "Hawken", OrganizerContactInfo = "216-578-9800", MaxTickets = 100, AvailableTickets = 100},
                new Event { EventType = eventType.Single(e => e.Type == "Dinner or Gala"), EventTitle = "Annual Scholarship and Awards Gala", EventDescription = "Hawken 2018 Scholarships", EventStartDate = new DateTime(2018, 05, 25), EventStartTime = new TimeSpan(05, 00, 00), EventEndDate = new DateTime(2018, 05, 25), EventEndTime = new TimeSpan(07, 00, 00), EventLocation = "Hawken Gatesmills Campus", OrganizerName = "Hawken", OrganizerContactInfo = "426-678-9870", MaxTickets = 100 , AvailableTickets = 50},
                new Event { EventType = eventType.Single(e => e.Type == "Workshop"), EventTitle = "Monthly Compost Workshop", EventDescription = "Creating Awareness about food waste", EventStartDate = new DateTime(2018, 09, 01), EventStartTime = new TimeSpan(06, 00, 00), EventEndDate = new DateTime(2018, 09, 01), EventEndTime = new TimeSpan(11, 00, 00), EventLocation = "Downtown", OrganizerName = "Rust Belt Riders", OrganizerContactInfo = "216-342-8286", MaxTickets = 50, AvailableTickets = 50 }
            }.ForEach(a => context.Events.Add(a));
        }

    }
}