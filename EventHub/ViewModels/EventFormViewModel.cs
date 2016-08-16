using EventHub.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EventHub.ViewModels
{
    public class EventFormViewModel
    {

        [Required]
        public string Venue { get; set; }

        [Required]
        [FutureDate]
        public string Date { get; set; }

        [Required]
        public string Time { get; set; }
        [Required]
        public byte Topic { get; set; }
        [Required]
        public IEnumerable<Topic> Topics { get; set; }

        public DateTime GetDateTime()
        {
            return DateTime.Parse(string.Format("{0} {1}", Date, Time));
        }
    } 
}