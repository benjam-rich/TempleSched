using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TempleSched.Models
{
    //This allows the DbContext to be accessed for the database
    public class ListContext : DbContext
    {
        public ListContext(DbContextOptions<ListContext> options): base (options)
        { }

        public DbSet<Group> Groups { get; set; }
       // public DbSet<TimeModel> TimeModels { get; set; }
    }
}
