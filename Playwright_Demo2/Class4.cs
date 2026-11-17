using NUnit.Framework;
using System;
using System.Threading.Tasks;

namespace Playwright_Demo2
{
    [TestFixture]   // 🔴 THIS IS REQUIRED
    public class Class4
    {
        [OneTimeSetUp]
        public Task D()
        {
            Console.WriteLine("Prabhas");
            return Task.CompletedTask;
        }

        [SetUp]
        public Task F()
        {
            Console.WriteLine("RGV");
            return Task.CompletedTask;
        }

        [Test]
        public Task G()
        {
            Console.WriteLine("Vadu");
            return Task.CompletedTask;
        }

        [Test]
        public Task K()
        {
            Console.WriteLine("Eedu");
            return Task.CompletedTask;
        }

        [TearDown]
        public Task A()
        {
            Console.WriteLine("Nenu");
            return Task.CompletedTask;
        }

        [OneTimeTearDown]
        public Task E()
        {
            Console.WriteLine("Vanga");
            return Task.CompletedTask;
        }
    }
}
