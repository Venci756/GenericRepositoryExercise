using My.Employee.DomainModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace My.Employee.DataLayer.Interfaces
{
    public interface IRepository<T>where T: Entity
    {
        T Get(int id);
        ICollection<T> GetAll();
        int Insert(T item);
        int Update(T item);
        int Delete(int id);
    }
}
