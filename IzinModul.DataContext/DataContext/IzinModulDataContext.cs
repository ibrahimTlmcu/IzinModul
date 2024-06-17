using IzinModul.DataContext.DbModels;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IzinModul.DataContext.DataContext
{
    public class IzinModulDataContext : IdentityDbContext
    {
        public IzinModulDataContext(DbContextOptions options) : base(options)
        {


        }
        public DbSet<Employee> Employee { get; set; }   

        public DbSet<EmployeeLeaveAlllocation> EmployeeLeaveAlllocation { get; set;}

        public DbSet<EmployeeLeaveType> EmployeeLeaveTypes { get; set; }



    }
}
