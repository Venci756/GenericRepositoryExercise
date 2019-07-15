using Microsoft.EntityFrameworkCore;
using My.Employee.DataLayer.Interfaces;
using My.Employee.DomainModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace My.Employee.DataLayer
{
    public class BaseRepository<T> : IRepository<T> where T : Entity
    {
        private readonly ApplicationDbContext _db;
        public readonly DbSet<T> _entity;

        public BaseRepository(ApplicationDbContext context)
        {
            _db = context;
            _entity = _db.Set<T>();
        }
        public int Delete(int id)
        {
            var dbItem = _entity.FirstOrDefault(e => e.Id == id);
            _entity.Remove(dbItem);
            return _db.SaveChanges();
        }

        public T Get(int id)
        {
            return _entity.FirstOrDefault(e => e.Id == id);
        }

        public ICollection<T> GetAll()
        {
            return _entity.ToList();
        }

        public int Insert(T item)
        {
            _entity.Add(item);
           return _db.SaveChanges();
        }

        public int Update(T item)
        {
            var employee = _entity.Attach(item);
            employee.State = EntityState.Modified;
            return _db.SaveChanges();
        }
    }
}
