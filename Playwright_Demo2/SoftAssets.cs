using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;


namespace Playwright_Demo2
{
     public class SoftAssets
    {

        [Test]
        public void SoftAssertionExample()
        {
            int a = 10;
            int b = 5;

            Assert.Multiple(() =>
            {
                Assert.AreEqual(20, a + b);   
                Assert.IsTrue(a > b);         
             //   Assert.IsNotNull("NUnit");    
            });

            Console.WriteLine("Test continues even after failure");
        }
    }
}
