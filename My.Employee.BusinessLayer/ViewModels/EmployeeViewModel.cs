using System;
using System.Collections.Generic;
using System.Text;
using My.Employee.DomainModels.Enums;
using My.Employee.DomainModels.Models;
using My.Employee.DataLayer;

namespace My.Employee.BusinessLayer.ViewModels
{
    public class EmployeeViewModel
    {
        public EmployeeViewModel(MyEmployee employee)
        {
            Name = employee.Name;
            LastName = employee.LastName;
            Departament = employee.Departament;
        }
        public string Name { get; set; }
        public string LastName { get; set; }
        public Departament Departament { get; set; }

    }
}
