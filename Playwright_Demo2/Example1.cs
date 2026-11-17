using Microsoft.Playwright;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playwright_Demo2
{
    public class Example1
    {
        public class Hard1
        {

            [Test]
            public async Task nk()
            {
                using var a = await Playwright.CreateAsync();
                var b = await a.Chromium.LaunchAsync(new BrowserTypeLaunchOptions { Headless = false });
                var context = await b.NewContextAsync();
                var page = await context.NewPageAsync();
             
                await page.WaitForTimeoutAsync(4000);
                await page.GotoAsync("https://www.flipkart.com/");

                await page.WaitForTimeoutAsync(2000);
                await page.TypeAsync("//input[@name=\"q\"]", "Iphone 17 pro");
                await page.WaitForTimeoutAsync(2000);
                await page.PressAsync("//input[@name=\"q\"]", "Enter");
                await page.WaitForTimeoutAsync(4000);
                await page.ClickAsync("//div[text()='Apple iPhone 17 Pro (Deep Blue, 256 GB)']");
                await page.WaitForTimeoutAsync(4000);

                var pag = context.Pages;
                var child = pag.Last();



             var val1=   await child.Locator("//div[text()='₹1,34,900']").InnerTextAsync();
                await child.WaitForTimeoutAsync(4000);
                Console.WriteLine(val1);
                await child.WaitForTimeoutAsync(4000);




                //  var val = await page.Locator("//div[text()='₹1,34,900']").InnerTextAsync();
                //  Console.WriteLine(val);
                // await page.WaitForTimeoutAsync(2000);
                


            }
        }
    }
}
