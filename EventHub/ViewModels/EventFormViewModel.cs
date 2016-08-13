using EventHub.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EventHub.ViewModels
{
    public class EventFormViewModel
    {
        public string Venue { get; set; }
        public string Date { get; set; }
        public string Time { get; set; }
        public int Topic { get; set; }

        public IEnumerable<Topic> Topics { get; set; }
    }
}