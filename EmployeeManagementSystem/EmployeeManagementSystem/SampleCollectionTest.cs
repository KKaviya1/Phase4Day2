using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagementSystem
{
    [TestFixture]
    public class SampleCollectionTest
    {
        List<string> colors = new List<string> { "red", "white", "pink", "blue", "green" };

        [Test]
        public void ContainsTest()
        {
            Assert.That(colors.Contains("red"), Is.True);
            Assert.That(colors, Has.Member("red"));
         }
        [Test]
        public void NotContainsTest()
        {
            Assert.That(colors, Has.No.Member("yellow"));
        }

    }
}
