using UserService.Domain;
using UserService.Models;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace UserService.Repository
{
    public class Repository<T>:IRepository<T> where T :BaseEntity
    {
        private readonly ApplicationDbContext _context;
        DbSet<T> entities;

        public Repository(ApplicationDbContext context)
        {
            this._context = context;
            this.entities = _context.Set<T>();
        }

        public void Delete(T entity)
        {
      
        }

        public T Get(long id)
        {
            throw new System.NotImplementedException();
        }

        public System.Collections.Generic.IEnumerable<T> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public void Insert(T entity)
        {
            
        }

        public void Remove(T entity)
        {
       
        }

        public void SaveChanges()
        {
            
        }

        public void Update(T entity)
        {
            
        }
    }
}