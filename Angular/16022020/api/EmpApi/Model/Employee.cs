using System.ComponentModel.DataAnnotations;
namespace EmpApi.Model
{
    public class Employee
    {
        [Key]
        public int Ecode { get; set; }
        public string Ename { get; set; }

    }
}