using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TempleSched.Models
{
    public class ListContext : DbContext
    {
        public ListContext(DbContextOptions<ListContext> options): base (options)
        { }

        public DbSet<Group> Groups { get; set; }
    }
}
