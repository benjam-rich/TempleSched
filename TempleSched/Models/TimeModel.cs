using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TempleSched.Models
{
    public class TimeModel
    {
        [Key]
        [Required]
        public int TimeChosenId { get; set; }
        [Required]
        public string TimeChosen { get; set; }
    }
}
