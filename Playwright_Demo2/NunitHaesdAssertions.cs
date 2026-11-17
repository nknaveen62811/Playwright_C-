using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playwright_Demo2
{
    public class NunitHaesdAssertions
    {

        [Test]
        public async Task nk()
        {
            
             Assert.AreEqual(10, 10);
             Console.WriteLine("TEXT PASSES");

             string A = "NK";
             string B = "MK";

             Assert.AreNotEqual(A, B);
             Console.WriteLine("TEXt Executed");



             string aa = null;

            Assert.IsNull(aa);

            Console.WriteLine("YES AA IS A NULL");

            string bb = "NK";
            Assert.IsNotNull(bb);
            Console.WriteLine("bb is not a null it has a data ");

            //  await Expect(page).ToHaveURLAsync("https://testautomationpractice.blogspot.com/");

            //   await Expect(page).ToHaveTitleAsync("Automation Testing Practice");


            //  await page.CheckAsync("(//input[@name=\"gender\"])[1]");

            //   await Expect(page.Locator("(//input[@name=\"gender\"])[1]")).ToBeCheckedAsync();




            /*

             int age = 20;
             Assert.IsTrue(age > 18);
             Console.WriteLine("age is mastched");

             Assert.IsFalse(age > 20);
             Console.WriteLine("YES AGE IS LEESS");

                 Assert.Pass("FORCELY ACCESSING");
         
            int age = 20;
            Assert.That(age, Is.EqualTo(20));
            Console.WriteLine("Yes That");
            
            Assert.Fail("xxxx");
 

            string aa = null;

            Assert.IsNull(aa);
            Console.WriteLine("YES AA IS A NULL");
            string bb = "NK";
            Assert.IsNotNull(bb);
            Console.WriteLine("bb is not a null it has a data ");
            
            int aa = 10;
            int bb = 0;
            Assert.Throws<DivideByZeroException>(() =>
            {
                int cc= aa / bb;
                
            });
            Console.WriteLine("We do not print inside the throws");
              */
        }
    }
}