using My.Employee.DataLayer.Interfaces;
using My.Employee.DomainModels.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace My.Employee.DataLayer.Repositories
{
    public class EmployeeRepository : BaseRepository<MyEmployee>, IEmployeeRepository
    {
        public EmployeeRepository(ApplicationDbContext context) : base(context)
        {

        }
    }
}
