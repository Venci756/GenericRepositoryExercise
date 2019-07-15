using Microsoft.EntityFrameworkCore;
using My.Employee.DomainModels.Models;
using System;

namespace My.Employee.DataLayer
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<MyEmployee> Employees { get; set; }
    }
}