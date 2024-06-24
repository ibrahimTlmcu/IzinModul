using IzinModulCommon.VModels;
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
            
           
             var resutl = data.Data;
            return View(resutl);
           
            
        }

        public IActionResult Create() 
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(EmployeeLeaveTypeVM model)
        {

            if(ModelState.IsValid)
            {
                var data = _employeeLeaveTypeBusinessEngine.CreateEmployeeLeaveType(model);
                if(data.IsSuccess)
                {
                    return RedirectToAction("Index");
                }
                else
                {
                    return View(model);
                }
            }
            else
            {
                return View(model);
            }


            
        }
        public IActionResult Edit()
        {
            return View();
        }


    }
}
