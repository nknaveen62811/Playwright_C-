using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playwright_Demo2
{
    internal class Real2
    {
        

[TestFixture]
        [Parallelizable(ParallelScope.Children)]
    public class LoginTests
    {
        [Test]
            
            [Category("Smoke")]

            public void Smoke_Login_ShouldWork()
        {
            TestContext.WriteLine("Running SMOKE test: Login basic check");
            Assert.IsTrue(true);
        }

        [Test]
        [Category("Regression")]
        public void Regression_Login_WithValidUser()
        {
            TestContext.WriteLine("Running REGRESSION test: Valid user login");
            Assert.IsTrue(true);
        }

        [Test]
        [Category("Regression")]
        public void Regression_Login_WithInvalidUser()
        {
            TestContext.WriteLine("Running REGRESSION test: Invalid user login");
            Assert.IsTrue(true);
        }
    }


}
}
