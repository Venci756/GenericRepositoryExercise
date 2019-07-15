using My.Employee.DomainModels.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace My.Employee.DomainModels.Models
{
    public class MyEmployee : Entity
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public Departament Departament { get; set; }
    }
}
