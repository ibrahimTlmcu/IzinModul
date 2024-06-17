using IzinModul.DataContext.Contracts;
using IzinModul.DataContext.DataContext;
using IzinModul.DataContext.DbModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace IzinModul.DataContext.Implementaion
{
    public class EmployeeLeaveAlllocationRepository : Repository<EmployeeLeaveAlllocation>, IEmployeeLeaveAlllocationRepository
    {
        private readonly IzinModulDataContext _ctx;

        public EmployeeLeaveAlllocationRepository(IzinModulDataContext ctx) : base(ctx)
        {
            _ctx = ctx;
        }

        public void Add(DbModels.EmployeeLeaveAlllocation entity)
        {
            throw new NotImplementedException();
        }

        public IQueryable<DbModels.EmployeeLeaveAlllocation> GetAll(Expression<Func<DbModels.EmployeeLeaveAlllocation, bool>> filter = null, Func<IQueryable<DbModels.EmployeeLeaveAlllocation>, IOrderedQueryable<DbModels.EmployeeLeaveAlllocation>> orderBy = null, string includeProperties = null)
        {
            throw new NotImplementedException();
        }

        public DbModels.EmployeeLeaveAlllocation GetFirstOrDefault(Expression<Func<DbModels.EmployeeLeaveAlllocation, bool>> filter = null, string includeProperties = null)
        {
            throw new NotImplementedException();
        }

        public void Remove(DbModels.EmployeeLeaveAlllocation entity)
        {
            throw new NotImplementedException();
        }

        public void Update(DbModels.EmployeeLeaveAlllocation entity)
        {
            throw new NotImplementedException();
        }

        DbModels.EmployeeLeaveAlllocation IRepositoryBase<DbModels.EmployeeLeaveAlllocation>.Get(int id)
        {
            throw new NotImplementedException();
        }
    }
}
