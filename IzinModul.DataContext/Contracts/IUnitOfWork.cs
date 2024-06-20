﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IzinModul.DataContext.Contracts
{
    public interface IUnitOfWork : IDisposable
    {
        IEmployeeLeaveAlllocationRepository employeeLeaveAlllocationRepository { get; }
        IEmployeeLeaveRequesRepository employeeLeaveRequesRepository { get; }
        IEmployeeLeaveTypeRepository employeeLeaveTypeRepository { get; }
        void Save(); 
    }
}
