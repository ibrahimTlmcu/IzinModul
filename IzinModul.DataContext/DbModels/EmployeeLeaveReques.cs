using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IzinModul.DataContext.DbModels
{
    public  class EmployeeLeaveReques : BaseEntity
    {
        //
        //Talepte Bulunan Kullanicilarin bilgileri
        public string RequestingEmployeeId { get; set; }
        [ForeignKey("RequestingEmployeeId")]
        public Employee RequestingEmployee { get; set; }


        /// <summary>
        /// Onaylayan Kullanici bilgileri
        /// </summary>
        public string ApprovedEmlooyeId { get; set; }
        [ForeignKey("ApprovedEmplooyeID")]
        public Employee ApprovedEmplooye { get; set; }



        public int EmployeeLeaveTypeId { get; set; }
        [ForeignKey("EmployeeLeaveTypeId")]
        public EmployeeLeaveType EmployeeLeaveType { get; set; }


        //-------------------------------------------//

        public DateTime StartDate { get; set; }
        public DateTime EndTime { get; set; }

        public DateTime RequestComments { get; set; }

        public bool Approved { get; set; }
        public bool Cancelled { get; set; }


    }
}
