using My.Employee.BusinessLayer.Interfaces;
using My.Employee.BusinessLayer.ViewModels;
using My.Employee.DataLayer.Interfaces;
using My.Employee.DomainModels.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace My.Employee.BusinessLayer.Services
{
    public class EmployeeSevice : IEmployeeService
    {
        private readonly IEmployeeRepository _employeeRepository;
        public EmployeeSevice(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }
        public int Add(CreateEmployeeViewModel model)
        {
            var employee = new MyEmployee();
            employee.Name = model.Name;
            employee.LastName = model.LastName;
            employee.Departament = model.Departament;

            return _employeeRepository.Insert(employee);
        }

        public int Edit(EditEmployeeViewModel model)
        {
            var employee = new MyEmployee();
            employee.Name = model.Name;
            employee.LastName = model.LastName;
            employee.Departament = model.Departament;
            return _employeeRepository.Update(employee);
        }

        public EmployeeViewModel GetById(int id)
        {
            var employee = _employeeRepository.Get(id);
            return new EmployeeViewModel(employee);
            
        }

        public List<EmployeeViewModel> GetAllEmployees()
        {
            var employees = _employeeRepository.GetAll().ToList();
            List<EmployeeViewModel> result = new List<EmployeeViewModel>();
            foreach (var employee in employees)
            {
                result.Add(new EmployeeViewModel(employee));
            }
            return result;
        }

        public int Remove(int id)
        {
            var removedEmployee = _employeeRepository.Delete(id);
            return removedEmployee;
        }
    }
}
