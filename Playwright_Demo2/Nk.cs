using Microsoft.Playwright;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playwright_Demo2
{
    public class Nk
    {
        [Test]
        public async Task nk()
        {
            using var a = await Playwright.CreateAsync();
            var b = await a.Chromium.LaunchAsync(new BrowserTypeLaunchOptions { Headless = false });
            var context = await b.NewContextAsync();
            var page = await context.NewPageAsync();
            await page.GotoAsync("https://www.flipkart.com/");

            /*
                        var d = page.Locator("//input[@name=\"q\"]");
                      await  d.FillAsync("Mobiles");
                        await d.PressAsync("Enter");
            */
            await page.TypeAsync("//input[@name=\"q\"]", "Samsung Galaxy F36 5G (Black, 128 GB)  (6 GB RAM)");
            await page.PressAsync("//input[@name=\"q\"]", "Enter");

            var g = page.Locator("(//li[text()='5000 mAh Battery'])[1]");
            string j = await g.InnerTextAsync();

            Console.WriteLine(j);
           

            await page.WaitForTimeoutAsync(6000);
          await  page.ClickAsync("(//div[@class=\"KzDlHZ\"])[1]");
            await page.WaitForTimeoutAsync(6000);
        }
    }
}
