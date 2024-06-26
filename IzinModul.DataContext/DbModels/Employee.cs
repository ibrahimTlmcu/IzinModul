﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IzinModul.DataContext.DbModels
{
    public class Employee : IdentityUser
    {
        public string ?FirstName { get; set; }
        public string ?LastName { get; set; }
        public string ?TaxId { get; set; }
        public DateTime DateofBirth { get; set; }
    }
}
