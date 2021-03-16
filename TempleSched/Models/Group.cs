﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TempleSched.Models
{
    public class Group
    {
        [Key]
        [Required]
        public int GroupId { get; set; }

        [Required]
        public string Name { get; set; }
        [Required]
        public int Size { get; set; }
        [Required]
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        [Required]
        public string TimeChosen { get; set; } //TimeModel
    }
}
