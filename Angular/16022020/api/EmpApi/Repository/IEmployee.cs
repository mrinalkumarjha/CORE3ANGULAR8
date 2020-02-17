using System.Collections.Generic;
using EmpApi.Model;
namespace EmpApi.Repository
{
    public interface IEmployee
    {
         IEnumerable<Employee> FetchEmployee();
         int SaveEmployee(Employee onbj);
    }
}