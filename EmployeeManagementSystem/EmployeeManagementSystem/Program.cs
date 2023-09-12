using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagementSystem
{
    internal class Program
    {
        public List<Employee>AllEmployees()
        {
            List<Employee> employees = new List<Employee>()
            {
                   new Employee(){Id=1,Name="Viya",Salary=86000.60,Designation="Developer",Doj=new DateTime(day:29,month:05,year:2023)},
                   new Employee(){Id=2,Name="Aishu",Salary=76000.60,Designation="Testing",Doj=new DateTime(day:26,month:05,year:2023)},
                   new Employee(){Id=3,Name="Praveen",Salary=96000.60,Designation="Programmer",Doj=new DateTime(day:23,month:05,year:2023)},
                   new Employee(){Id=4,Name="Soonil",Salary=62000.60,Designation="Testing",Doj=new DateTime(day:27,month:05,year:2023)},
            };
            return employees;
        }
        public Employee EmpDetails(int id)
        {
            List<Employee> list = AllEmployees();
            Employee emp = list.SingleOrDefault(e => e.Id == id);
            return emp;
        }
        static void Main(string[] args)
        {
        }
    }
}
