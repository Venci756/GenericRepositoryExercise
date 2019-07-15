using System;
using System.Collections.Generic;
using System.Text;
using My.Employee.DomainModels.Models;

namespace My.Employee.DataLayer.Interfaces
{
    public interface IEmployeeRepository : IRepository<MyEmployee>
    {
    }
}
