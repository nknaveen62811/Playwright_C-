using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

using System.Threading.Tasks;

namespace Playwright_Demo2
{
    [TestFixture]
    public class Attributes
    {
        [OneTimeSetUp]
        public async Task nk1()
        {
            Console.WriteLine("EXECUTES BEFORE THE METHODS");
        }
        [OneTimeTearDown]
        public async Task nk2()
        {
            Console.WriteLine("Executes after the class");

        }
        [SetUp]
        public async Task nk3()
        {
            Console.WriteLine("exectes before the test");

        }
        [TearDown]
        public async Task nk4()
        {
            Console.WriteLine("Executes after the method");

        }
        [Test]
        public async Task nk5()
        {
            Console.WriteLine("Executing the test method");
        }
    }
}
