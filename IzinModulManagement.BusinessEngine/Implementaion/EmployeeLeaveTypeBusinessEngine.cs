using AutoMapper;
using IzinModul.DataContext.Contracts;
using IzinModul.DataContext.DbModels;
using IzinModulCommon.ConstantModels;
using IzinModulCommon.ResultModels;
using IzinModulCommon.VModels;
using IzinModulManagement.BusinessEngine.Contracts;
using System;
using System.Collections.Generic;

using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IzinModulManagement.BusinessEngine.Implementaion
{
    
    public class EmployeeLeaveTypeBusinessEngine : IEmployeeLeaveTypeBusinessEngine
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;


        public EmployeeLeaveTypeBusinessEngine(IUnitOfWork unitOfWork,IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
           
         
        }

        public Result<List<EmployeeLeaveTypeVM>> GetAllEmployeeLeaveTypes()
        {
            var data = _unitOfWork.employeeLeaveTypeRepository.GetAll().ToList();
            //if(data != null)
            //{
            //    List<EmployeeLeaveType> returnData = new List<EmployeeLeaveType>();

            //    foreach(var item in data)
            //    {
            //        returnData.Add(new EmployeeLeaveType()
            //        {
            //            Id = item.Id,
            //            DateCreated = item.DateCreated,
            //            DefultDays = item.DefultDays,
            //            Name = item.Name
            //        }); ;

            //    }

            //    return new Result<List<EmployeeLeaveType>>( true,ResultConstant.RecordFound, returnData );
            //}
            //else
            //{
            //    return new Result<List<EmployeeLeaveType>>(false,ResultConstant.RecordNotFound);
            //}

            var leaveTypes = _mapper.Map<List<EmployeeLeaveType>, List<EmployeeLeaveTypeVM>>(data);
            return new Result<List<EmployeeLeaveTypeVM>>(false, ResultConstant.RecordNotFound, leaveTypes);

        }

		Result<List<EmployeeLeaveType>> IEmployeeLeaveTypeBusinessEngine.GetAllEmployeeLeaveTypes()
		{
			throw new NotImplementedException();
		}
	}
}
