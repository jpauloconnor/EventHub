﻿using System.ComponentModel.DataAnnotations;

namespace EventHub.Models
{
    public class Topic
    {
        public byte Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }  
    }
}