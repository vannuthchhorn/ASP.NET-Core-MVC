using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AppEmployee.Models;

namespace AppEmployee.Data
{
    public class AppEmployeeContext : DbContext
    {
        public AppEmployeeContext (DbContextOptions<AppEmployeeContext> options)
            : base(options)
        {
        }

        public DbSet<AppEmployee.Models.Movie> Movie { get; set; }
    }
}
