using Microsoft.Playwright;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playwright_Demo2
{
    public class Window1
    {
        [Test]
        public async Task nk()
        {
            using var a = await Playwright.CreateAsync();
            var b = await a.Chromium.LaunchAsync(new BrowserTypeLaunchOptions { Headless = false });
            var context = await b.NewContextAsync();
            var page = await context.NewPageAsync();
            await page.GotoAsync("https://www.flipkart.com/");
            await page.FillAsync("//input[@name='q']", "Samsung Galaxy F54 5G (Stardust Silver, 256 GB)  (8 GB RAM)");
            await page.PressAsync("//input[@name='q']", "Enter");
            await page.WaitForTimeoutAsync(4000);
            await page.ClickAsync("//div[@class='KzDlHZ']");
            await page.WaitForTimeoutAsync(4000);
            var pages = context.Pages;
            var child = pages[1];

            await child.BringToFrontAsync();
            await child.WaitForTimeoutAsync(2000);

            var ele = child.Locator("//div[text()='Samsung Galaxy F54 5G (Stardust Silver, 256 GB)']");
            string str = await ele.InnerTextAsync();
            Console.WriteLine(str);

            await page.WaitForTimeoutAsync(4000);





            
        }
    }
}