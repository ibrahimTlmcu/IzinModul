﻿using IzinModul.DataContext.DbModels;
using IzinModulCommon.ResultModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IzinModulManagement.BusinessEngine.Contracts
{
    public interface IEmployeeLeaveTypeBusinessEngine
    {
        Result<List<EmployeeLeaveType>> GetAllEmployeeLeaveTypes();


    }
}
