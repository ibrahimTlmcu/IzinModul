using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IzinModulCommon.VModels
{
    public class EmployeeLeaveRequestVM : BaseVM

    {
    
        public string ?RequestingEmployeeId { get; set; }
      
        public EmployeeVM ?RequestingEmployee { get; set; }


        /// <summary>
        /// Onaylayan Kullanici bilgileri
        /// </summary>
        public string ?ApprovedEmlooyeId { get; set; }
 
        public EmployeeVM ?ApprovedEmplooye { get; set; }



        public int EmployeeLeaveTypeId { get; set; }
        [ForeignKey("EmployeeLeaveTypeId")]
        public EmployeeLeaveTypeVM?EmployeeLeaveType { get; set; }


        //-------------------------------------------//

        public DateTime StartDate { get; set; }
        public DateTime EndTime { get; set; }

        [Display(Name="Talep Aciklama")]
       //Max length eklenecek
        public DateTime RequestComments { get; set; }

        public bool Approved { get; set; }
        public bool Cancelled { get; set; }
    }
}
