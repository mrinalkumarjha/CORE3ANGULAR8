using System.Threading.Tasks;
using System.Collections.Generic;
using System;
using UserService.Models;
namespace UserService.Repository
{
    public interface IRepository<T> where T : BaseEntity
    {
         IEnumerable<T> GetAll();
        T Get(long id);
        void Insert(T entity); // by task seperate thread and seperate processor
        void Update(T entity);
        void Delete(T entity);
        void Remove(T entity);
        void SaveChanges();
        
    } 
}