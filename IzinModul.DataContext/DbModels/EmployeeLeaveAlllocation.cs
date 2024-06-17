using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IzinModul.DataContext.DbModels
{
    public class EmployeeLeaveAlllocation : BaseEntity
    {
        
        public int NumberOfDays { get; set; }
        public DateTime Datecreated { get; set; }

        public int Period { get; set; }

        public string EmployeeId { get; set; }

        [ForeignKey("EmployeeId")]
        public Employee Employee { get; set; }
        public int EmployeeLeaveTypeId { get; set; }

        [ForeignKey("EmployeeLeaveTypeId")]
        public EmployeeLeaveType EmployeeLeaveType { get; set; }
    }
}
