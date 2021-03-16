using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TempleSched.Models.ViewModels
{
    public class AppointmentViewModel
    {
        public IEnumerable<Group> groups { get; set; }
    }
}
