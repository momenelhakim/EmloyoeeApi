using System.CodeDom.Compiler;
using System.ComponentModel.DataAnnotations;

namespace EmloyoeeApi.Models
{
    public class Employee
    {
        [Key]
       
        public int Id { get; set; }
        public string Name { get; set; }
        public string Title { get; set; }
        public decimal Salary { get; set; } 
    }
}
