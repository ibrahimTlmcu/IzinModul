using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IzinModulCommon.VModels
{


    // EmployeeSalary a = EmployeeSalary();
    // EmployeeFree b = EmployeeFree();

    //a.Name = b.Name ;
    //Bu tarz yapilari kullanmamak icin AutoMapper kulliniyoruz.
    //Yani iki farkli tablodaki ogelerin eslenmesini istiyoruz
     


    public class EmployeeLeaveAllocationsVM : BaseVM
    {
        public  int  NumberOfDays { get; set; }

        public DateTime DataCreated { get; set; }

        public int Period { get; set; }
        public string EmployeeId { get; set; }

        public EmployeeVM EmpolyeeVm { get; set; }

        public int EmployeeLeaveTypeId { get; set; }
        public EmployeeLeaveTypeVM EmployeeLeaveTypeVm{ get; set; }
    }
}
