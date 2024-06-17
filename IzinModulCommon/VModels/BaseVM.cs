using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IzinModulCommon.VModels
{
    public class BaseVM
    {
        [Key]
        public int Id { get; set; }

    }
}
