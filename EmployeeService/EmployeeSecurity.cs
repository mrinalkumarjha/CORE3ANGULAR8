using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeeDataAccess;
namespace EmployeeService
{
    public class EmployeeSecurity
    {
        public static bool Login(string username, string password)
        {
            using(EmployeeDBEntities entities = new EmployeeDBEntities())
            {
                return entities.Users.Any(users => users.Username.Equals(username, 
                    StringComparison.OrdinalIgnoreCase) && users.Password.Equals(password));
            }
        }
    }
}
