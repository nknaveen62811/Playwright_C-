using Microsoft.Playwright;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playwright_Demo2
{
    public class Demo1s
    {

        [Test]
        public async Task nk()
        {
            using var a = await Playwright.CreateAsync();
            var b = await a.Chromium.LaunchAsync(new BrowserTypeLaunchOptions { Headless = false });
            var context = await b.NewContextAsync();
            var page = await context.NewPageAsync();

            string url1 = "https://www.spacex.com/";

            await page.GotoAsync(url1);

            await page.WaitForTimeoutAsync(4000);

               for(int A=1;A<=170;A++)
               {
                   await page.Keyboard.PressAsync("ArrowDown");

               }
            

          //  await page.Locator("//a[text()='Careers']/../..").ScrollIntoViewIfNeededAsync();

            await page.WaitForTimeoutAsync(2000);

            await page.ClickAsync("//a[text()='Careers']");

            await page.WaitForTimeoutAsync(4000);

            await page.ClickAsync("//a[text()='Starlink']");

            await page.WaitForTimeoutAsync(2000);


            var pag = context.Pages;

            await pag[1].BringToFrontAsync();

            await pag[1].WaitForTimeoutAsync(2000);

            await pag[1].HoverAsync("//p[text()='Learn']");



           
            await pag[1].WaitForTimeoutAsync(2000);

           
            var elements = await pag[1].Locator("//p[text()='Availability Map']/../../..//a").AllInnerTextsAsync();

            await pag[1].WaitForTimeoutAsync(4000);

            foreach (var y in elements)
            {
                Console.WriteLine(y);
            }

            

            await pag[1].WaitForTimeoutAsync(4000);

        }
    }
}