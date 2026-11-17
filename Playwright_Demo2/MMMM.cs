using Microsoft.Playwright;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playwright_Demo2
{
    public class MMMM
    {

        [Test]
        public async Task nk()
        {
            using var a = await Playwright.CreateAsync();
           var b = await a.Chromium.LaunchAsync(new BrowserTypeLaunchOptions { Headless = false });
            var context = await b.NewContextAsync();
            var page = await context.NewPageAsync();




            Assert.Multiple(() =>
            {
                Assert.AreEqual(25, 26); // ❌ fails

                page.GotoAsync("https://testautomationpractice.blogspot.com/");
            });







            await page.WaitForTimeoutAsync(4000);

        }
    }
}