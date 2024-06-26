﻿using AutoMapper;
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


        public EmployeeLeaveTypeBusinessEngine(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;


        }

        public Result<EmployeeLeaveRequestVM> CreateEmployeeLeaveType(EmployeeLeaveTypeVM model)
        {
            if (model != null)
            {
                try
                {
                    var leaveType = _mapper.Map<EmployeeLeaveTypeVM, EmployeeLeaveType>(model);
                    leaveType.DateCreated = DateTime.Now;
                    _unitOfWork.employeeLeaveTypeRepository.Add(leaveType);
                    _unitOfWork.Save();
                    return new Result<EmployeeLeaveRequestVM>(true, ResultConstant.RecordFound, default(EmployeeLeaveRequestVM), 0);
                }
                catch (Exception ex)
                {
                    return new Result<EmployeeLeaveRequestVM>(false, ex.Message.ToString(), default(EmployeeLeaveRequestVM), 0);
                }
            }
            else
            {
                return new Result<EmployeeLeaveRequestVM>(false, "Parametre", default(EmployeeLeaveRequestVM), 0);
            }

        }




        public Result<List<EmployeeLeaveTypeVM>> GetAllEmployeeLeaveTypes()
        {
            var data = _unitOfWork.employeeLeaveTypeRepository.GetAll().ToList();
            //if (data != null)
            //{
            //    List<EmployeeLeaveType> returnData = new List<EmployeeLeaveType>();

            //    foreach (var item in data)
            //    {
            //        returnData.Add(new EmployeeLeaveType()
            //        {
            //            Id = item.Id,
            //            DateCreated = item.DateCreated,
            //            DefaultDays = item.DefaultDays,
            //            Name = item.Name
            //        }); ;

            //    }

            //    var leaveTypeVMs = _mapper.Map<List<EmployeeLeaveTypeVM>>(data);

            //    return new Result<List<EmployeeLeaveTypeVM>>(true, ResultConstant.RecordFound, leaveTypeVMs);

            //}


            //else
            //{
            //    return new Result<List<EmployeeLeaveType>>(false, ResultConstant.RecordFound, data, 0);

            //}

            var leaveTypes = _mapper.Map<List<EmployeeLeaveType>, List<EmployeeLeaveTypeVM>>(data);
            return new Result<List<EmployeeLeaveTypeVM>>(false, ResultConstant.RecordNotFound, leaveTypes);

        }


        Result<EmployeeLeaveTypeVM> IEmployeeLeaveTypeBusinessEngine.GetAllEmployeeLeaveTypes(int id)
        {
            var data = _unitOfWork.employeeLeaveTypeRepository.Get(id);
            if (data != null)
            {
                var leaveType = _mapper.Map<EmployeeLeaveType, EmployeeLeaveTypeVM>(data);
                return new Result<EmployeeLeaveTypeVM>(true, ResultConstant.RecordFound, default(EmployeeLeaveTypeVM), 0);
            }
            else
            {
                return new Result<EmployeeLeaveTypeVM>(false, "ASDFADF", default(EmployeeLeaveTypeVM), 0);
            }
        }

        public Result<EmployeeLeaveTypeVM> EditEmployeeLeaveType(EmployeeLeaveTypeVM model)
        {
            if (model != null)
            {
                try
                {
                    var leavetype = _mapper.Map<EmployeeLeaveTypeVM, EmployeeLeaveType>(model);
                    _unitOfWork.employeeLeaveTypeRepository.Update(leavetype);
                    _unitOfWork.Save();
                    return new Result<EmployeeLeaveTypeVM>(true, "Update Succes", default, 0);

                }
                catch (Exception ex)
                {
                    return new Result<EmployeeLeaveTypeVM>(true, "" + ex.Message.ToString(), default);


                };
            }
            else
            {
                return new Result<EmployeeLeaveTypeVM>(false, "Update Succes", default, 0);

            }
        }




        public Result<EmployeeLeaveTypeVM> RemoveEmployeeLeaveType(int id)
        {
            var data = _unitOfWork.employeeLeaveTypeRepository.Get(id);
            if (data != null)
            {
               
                _unitOfWork.employeeLeaveTypeRepository.Remove(data);
                _unitOfWork.Save();
                return new Result<EmployeeLeaveTypeVM>(true, "Update Succes", default, 0);
            }
            else
                return new Result<EmployeeLeaveTypeVM>(false, "Update not", default, 0);
        }

    }
}


 
