﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace IzinModul.DataContext.DbModels
{
    public class EmployeeLeaveType : BaseEntity 
    {

        [Required]
        public string ?Name { get; set; }

        public int? DefaultDays { get; set; }

        public DateTime? DateCreated { get; set; }

        public bool IsActive { get; set; }

        public void SetEmployeeType(string name)
		{
			this.Name = name;
		}

	}
}
