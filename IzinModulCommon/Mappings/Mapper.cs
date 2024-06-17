using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IzinModul.DataContext.DbModels;
using IzinModulCommon.VModels;

namespace IzinModulCommon.Mappings
{
    public class Mapper : Profile
    {

        public Mapper()
        {
            CreateMap<EmployeeLeaveType, EmployeeLeaveRequestVM>().ReverseMap();
            // Gelen tablolarin yerini degistridik.
            CreateMap<EmployeeLeaveAlllocation, EmployeeLeaveAllocationsVM>().ReverseMap();
            CreateMap<EmployeeLeaveReques, EmployeeLeaveRequestVM>().ReverseMap();
            CreateMap<Employee, EmployeeVM>().ReverseMap();



        }

    }
}
