using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using My.Employee.BusinessLayer.Interfaces;
using My.Employee.BusinessLayer.ViewModels;

namespace My.Employee.App.Controllers
{
    public class MyEmployeeController : Controller
    {
        private readonly IEmployeeService _service;
            public MyEmployeeController(IEmployeeService service)
        {
            _service = service;
        }
        public IActionResult Index()   //EmployeeViewModel
        {
           var result = _service.GetAllEmployees().ToList();
            return View(result);
        }
        public IActionResult Details(int id)
        {
          var result = _service.GetById(id);
            return View(result);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(CreateEmployeeViewModel employee)
        {
            _service.Add(employee);
            return RedirectToAction("Index");
        }

        public IActionResult Edit(int id)
        {
            var result = _service.GetById(id);
            EditEmployeeViewModel employee = new EditEmployeeViewModel
            {
                Name = result.Name,
                LastName = result.LastName,
                Departament = result.Departament
              
            };
            return View(employee);
        }
        [HttpPost]
        public IActionResult Edit(EditEmployeeViewModel employe)
        {
           var modified = _service.Edit(employe);
            if(modified != 0)
            {
                return RedirectToAction("Index");
            }
            return View();
        }
    }
}