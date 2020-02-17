using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using EmpApi.Model;
using EmpApi.Repository;
namespace EmpApi.Controllers
{
    // this is endpoint
    // endpoint is collection of route.
    // untill we use ControllerBase we cant get httpverb feature
    [ApiController]
    [Route("[controller]")]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployee _employee;

        public EmployeeController(IEmployee employee)
        {
            this._employee = employee;

        }


        [HttpGet]
        public IEnumerable<Employee> GetEmp()
        {
            return this._employee.FetchEmployee();
        }


        [HttpPost]
        public int PostEmployee([FromBody] Employee emp) {
           return _employee.SaveEmployee(emp);
        }


    }
}