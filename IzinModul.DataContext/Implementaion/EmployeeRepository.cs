using IzinModul.DataContext.Contracts;
using IzinModul.DataContext.DataContext;
using IzinModul.DataContext.DbModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IzinModul.DataContext.Implementaion
{
    public  class EmployeeRepository : Repository<Employee> , IEmployeeRepository
    {
        private readonly IzinModulDataContext _ctx;

        public EmployeeRepository(IzinModulDataContext ctx) : base(ctx)
        {
             _ctx = ctx;
        }
        

    }
}
