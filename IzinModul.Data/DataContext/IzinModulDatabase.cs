using System;
using System.Collections.Generic;
using Microsoft.AspNet.Identity.EntityFramework;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Options;

namespace IzinModul.Data.DataContext
{
    public class IzinModulDatabase : IdentityDbContext
    {
        public IzinModulDatabase(DbContextOptions options) base : (options)
        {

        } 

    }
}
