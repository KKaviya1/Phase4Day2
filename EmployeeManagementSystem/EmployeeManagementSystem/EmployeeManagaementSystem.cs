using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagementSystem
{
    [TestFixture]
    public class EmployeeManagaementTest
    {
        Program obj;
        List<Employee> list;
        [Test]
        public void NotnullTest()
        {
            obj = new Program();
                list = obj.AllEmployees();
            foreach(var item in list)
            {
                Assert.IsNotNull(item.Id);
                Assert.IsNotNull(item.Name);
                Assert.IsNotNull(item.Designation);
                Assert.IsNotNull(item.Salary);
                Assert.IsNotNull(item.Doj);
            }
        }
        [Test]
        public void EmpDetailsTest()
        {
            int id =1;
            string name = "Viya";
            double salary = 86000.60;
            string designation = "Developer";
            DateTime doj = new DateTime(day: 29, month: 05, year: 2023);
            obj = new Program();
            Employee emp = obj.EmpDetails(id);
            Assert.AreEqual(salary, emp.Salary);
            Assert.AreEqual(name, emp.Name);
            Assert.AreEqual(designation, emp.Designation);
            Assert.AreEqual(doj, emp.Doj);
        }
    }
    }
