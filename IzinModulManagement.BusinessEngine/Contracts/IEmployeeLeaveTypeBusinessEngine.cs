﻿using IzinModul.DataContext.DbModels;
using IzinModulCommon.ResultModels;
using IzinModulCommon.VModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IzinModulManagement.BusinessEngine.Contracts
{
    public interface IEmployeeLeaveTypeBusinessEngine
    {
        Result<List<EmployeeLeaveTypeVM>> GetAllEmployeeLeaveTypes();
        Result<EmployeeLeaveRequestVM> CreateEmployeeLeaveType(EmployeeLeaveTypeVM model);
        
        //Kayitlari getirmek icin
        Result<EmployeeLeaveTypeVM> GetAllEmployeeLeaveTypes(int id);

        //Kayitlari duzenledikten sonra tekrar gondermek icin.

        Result<EmployeeLeaveTypeVM> EditEmployeeLeaveType(EmployeeLeaveTypeVM model);
        Result<EmployeeLeaveTypeVM> RemoveEmployeeLeaveType(int id);

     
        




    }
}
