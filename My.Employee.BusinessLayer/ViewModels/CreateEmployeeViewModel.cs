using My.Employee.DomainModels.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace My.Employee.BusinessLayer.ViewModels
{
    public class CreateEmployeeViewModel
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public Departament Departament { get; set; }
    }
}
