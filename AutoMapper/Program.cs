using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;

namespace AutoMapper
{
    class Program
    {
        static void Main(string[] args)
        {
            // install automapper from nuget 
            // i have used 4.1.1
            // automapper is two step process
            // automapper internally use reflectio to see properties of type and map it
            Mapper.Initialize(p => p.AddProfile<MappingProfile>()); // this should be in startup folder

            Order o = new Order();
            o.id = 1;
            o.name = "order1";
            o.amt = 2020;

            OrderDto odto = Mapper.Map<OrderDto>(o);
        }
    }

    class Order
    {
        public int id { get; set; }
        public string name { get; set; }
        public int amt { get; set; }
    }

    class OrderDto
    {
        public int id { get; set; }
        public string name { get; set; }
    }


    class Employee
    {
        public int id { get; set; }
        public string name { get; set; }
        public int amt { get; set; }
    }

    class EmployeeDto
    {
        public int EmpId { get; set; }
        public string EmpName { get; set; }
    }

}
