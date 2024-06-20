using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IzinModulCommon.ResultModels
{
    public class Result<T> : IResult //Herhangi bir tip gelebilir diye Generic tanimladik
    {

		public bool IsSuccess { get; set; }
        public string Message { get ; set; }


        public T Data {  get; set; }
        public int TotalCount { get; set; }

        public Result(bool isSucces,string message, List<VModels.EmployeeLeaveTypeVM> leaveTypes) :this(isSucces,message,default(T))
        {
            
        }
        public Result(bool isSucces, string message,T data) : this(isSucces, message, data,0)
        {

        }
        public Result(bool isSucces, string message,T data,int totalCount) 
        {
            IsSuccess = isSucces;
            Message = message;
            Data = data;
            TotalCount = totalCount;

        }

		
	}
}
