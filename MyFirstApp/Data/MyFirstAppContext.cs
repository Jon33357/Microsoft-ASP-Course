using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace MyFirstApp.Models
{
    public class MyFirstAppContext : DbContext
    {
        public MyFirstAppContext (DbContextOptions<MyFirstAppContext> options)
            : base(options)
        {
        }

        public DbSet<MyFirstApp.Models.Movie> Movie { get; set; }
    }
}
