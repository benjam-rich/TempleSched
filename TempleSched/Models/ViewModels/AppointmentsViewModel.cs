using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TempleSched.Models.ViewModels
{
    //This is the view model that allows the appointments to be iterated from the database
    public class AppointmentsViewModel
    {
        public IEnumerable<Group> groups { get; set; }
    }
}
