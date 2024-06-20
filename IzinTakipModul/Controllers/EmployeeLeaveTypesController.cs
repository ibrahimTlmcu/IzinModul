using IzinModulManagement.BusinessEngine.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace IzinTakipModul.Controllers
{
    public class EmployeeLeaveTypesController : Controller
    {
        private readonly  IEmployeeLeaveTypeBusinessEngine _employeeLeaveTypeBusinessEngine;

        public EmployeeLeaveTypesController(IEmployeeLeaveTypeBusinessEngine employeeLeaveTypeBusinessEngine)
        {
            _employeeLeaveTypeBusinessEngine = employeeLeaveTypeBusinessEngine;
        }

        //Burdan gelen veriler Result<T> ile isleme alinacak ve hata basarili gibi mesajlar donebilecek
        public IActionResult Index()
        {
            var data = _employeeLeaveTypeBusinessEngine.GetAllEmployeeLeaveTypes();
            if (data.IsSuccess)
            {
                var resutl = data.Data;
                return View(resutl);
            }
            return View();
        }
    }
}
