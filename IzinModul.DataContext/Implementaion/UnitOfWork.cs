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
    /// <summary>
    /// Onregin bir islem yapilirken ilk iki tabloda islem yapildi ancak ucuncu tabloda hata alindi
    /// bu islemi  kontrollu sekilde geri almaya yarar.Tek bir parca gibi davranir 
    /// Temel banka para cekme ornegi
    /// 
    /// </summary>
    public class UnitOfWork : IUnitOfWork
    {
        private readonly IzinModulDataContext _ctx;
        public UnitOfWork(IzinModulDataContext ctx)
        {
            _ctx = ctx;
            employeeLeaveAlllocation = new EmployeeLeaveAlllocationRepository(_ctx);
			employeeLeaveRequesRepository = new EmployeeLeaveRequestRepository(_ctx);
			employeeLeaveTypeRepository = new EmployeeLeaveTypeRepository(_ctx);

        }

		public IEmployeeLeaveAlllocationRepository employeeLeaveAlllocation {  get; private set; }

		public IEmployeeLeaveRequesRepository employeeLeaveRequesRepository { get; private set; }

		public IEmployeeLeaveTypeRepository employeeLeaveTypeRepository { get; private set; }

		public void Dispose()
        {
            _ctx.Dispose();
        }

        public void Save()
        {
            _ctx.SaveChanges();
        }
    }
}
