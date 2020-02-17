using System.Collections.Generic;
using System.Linq;
using EmpApi.Model;
using Microsoft.EntityFrameworkCore;
using EmpApi.Data;

namespace EmpApi.Repository
{
    public class EmpService : IEmployee
    {
        private readonly ApplicationDbContext _context;

        public EmpService(ApplicationDbContext context)
        {
            this._context = context;

        }
        public IEnumerable<Employee> FetchEmployee()
        {
            return _context.Employees.ToList();
        }

        public int SaveEmployee(Employee obj)
        {
           _context.Add(obj) ;
           _context.SaveChanges();
           return 1;
        }
    }
}