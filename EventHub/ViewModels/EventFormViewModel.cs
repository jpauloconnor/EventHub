using EventHub.Models;
using System.Collections.Generic;

namespace EventHub.ViewModels
{
    public class EventFormViewModel
    {
        public string Venue { get; set; }
        public string Date { get; set; }
        public string Time { get; set; }
        public byte Topic { get; set; }

        public IEnumerable<Topic> Topics { get; set; }
    }
}