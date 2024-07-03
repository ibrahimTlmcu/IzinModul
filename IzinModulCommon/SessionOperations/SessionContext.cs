using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IzinModulCommon.SessionOperations
{
    public class SessionContext
    {
        public string LoginId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public bool? isAdmin { get; set; }
    }
}
