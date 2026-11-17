using Microsoft.Playwright;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playwright_Demo2
{
    internal class window6
    {
        [Test]
        public async Task nk()
        {
            using var a = await Playwright.CreateAsync();
            var b = await a.Chromium.LaunchAsync(new BrowserTypeLaunchOptions { Headless = false });
            var context = await b.NewContextAsync();
            var page = await context.NewPageAsync();
            await page.GotoAsync("https://www.hyrtutorials.com/");
            await page.WaitForTimeoutAsync(2000);
            await page.Locator("//a[text()='Selenium Practice']").HoverAsync();
            await page.WaitForTimeoutAsync(2000);
            await page.Locator("//a[text()='Window Handles']").HoverAsync();
            await page.ClickAsync("//a[text()='Window Handles']");
            await page.WaitForTimeoutAsync(2000);
            await page.ClickAsync("//button[@id=\"newWindowBtn\"]");
            await page.WaitForTimeoutAsync(4000);

            /*
                    var pages =  context.Pages;
                    var child = pages.Last();
                    await child.Locator("//ul[@style=\"text-align: left;\"]").ScrollIntoViewIfNeededAsync();
                    await child.WaitForTimeoutAsync(2000);
                    var ele = child.Locator("//ul[@style=\"text-align: left;\"]");

                    var elem = await ele.InnerTextAsync();

                    Console.WriteLine(elem);
                    await child.WaitForTimeoutAsync(2000);
                    await child.FillAsync("//input[@id=\"firstName\"]", "venky");
                    await child.FillAsync("//input[@id=\"lastName\"]","Dhevudu");
                    await child.WaitForTimeoutAsync(7000);
            */
                            var np = context.Pages;
                            await np[1].Locator("//ul[@style=\"text-align: left;\"]").ScrollIntoViewIfNeededAsync();

                              await np[1].WaitForTimeoutAsync(2000);

                              var ele = np[1].Locator("//ul[@style=\"text-align: left;\"]");

                           var elem = await ele.InnerTextAsync();
                            Console.WriteLine(elem);
                             await np[1].WaitForTimeoutAsync(7000);
           
        }
    }

}