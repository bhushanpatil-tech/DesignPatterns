using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using EmployeeBusinessService.Models;

namespace WebApp.Data
{
    public class EmployeeContext : DbContext
    {
        public EmployeeContext (DbContextOptions<EmployeeContext> options)
            : base(options)
        {
        }

        public DbSet<EmployeeBusinessService.Models.Employee> Employee { get; set; }
        public DbSet<EmployeeBusinessService.Models.Employee_Type> Employee_Type { get; set; }
    }
}
