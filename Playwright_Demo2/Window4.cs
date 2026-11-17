using Microsoft.Playwright;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playwright_Demo2
{
    public class Window4
    {
        [Test]
        public async Task nk()
        {
            using var a = await Playwright.CreateAsync();
            var b = await a.Chromium.LaunchAsync(new BrowserTypeLaunchOptions { Headless = false });
            var context = await b.NewContextAsync();
            var page = await context.NewPageAsync();
            await page.GotoAsync("https://www.flipkart.com/");
            await page.FillAsync("//input[@name='q']", "OnePlus 13R 5g (Astral Trail, 256 GB)  (12 GB RAM)");
            await page.PressAsync("//input[@name='q']", "Enter");
            await page.WaitForTimeoutAsync(4000);
            await page.Locator("(//div[@class='KzDlHZ'])[1]").ClickAsync();
            await page.WaitForTimeoutAsync(3000);

            var pages = context.Pages;
            var child = pages.Last();

            await child.WaitForTimeoutAsync(2000);
            await child.ClickAsync("//button[@class='QqFHMw vslbG+ In9uk2']");
            await child.WaitForTimeoutAsync(2000);

            var flip = child.Locator("//div[@class='KTpSwS']");
            var sd =await flip.InnerTextAsync();
            string tit = await child.TitleAsync();
            Console.WriteLine(tit);

            Console.WriteLine(sd);
            await child.GoBackAsync();

            await child.WaitForTimeoutAsync(7000);
        }
    }
}