using My.Employee.BusinessLayer.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace My.Employee.BusinessLayer.Interfaces
{
    public interface IEmployeeService
    {
        int Add(CreateEmployeeViewModel model);
        int Edit(EditEmployeeViewModel model);
        int Remove(int id);
        EmployeeViewModel GetById(int id);
        List<EmployeeViewModel> GetAllEmployees();

    }
}
