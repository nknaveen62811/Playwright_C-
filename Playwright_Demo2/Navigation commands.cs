using Microsoft.Playwright;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playwright_Demo2
{
    public class Navigation_commands
    {
        [Test]
        public async Task nk()
        {
            using var a = await Playwright.CreateAsync();
            var b = await a.Chromium.LaunchAsync(new BrowserTypeLaunchOptions { Headless = false });
            var context = await b.NewContextAsync();
            var page = await context.NewPageAsync();
            await page.GotoAsync("https://www.hyrtutorials.com/");
         var a1=   page.Locator("//div[@class='body-row menu-wrap']");
            string bb = await a1.InnerTextAsync();
            Console.WriteLine(bb);
            await page.WaitForTimeoutAsync(6000);
            await page.Locator("(//a[text()='Contact'])[2]").ClickAsync();
            await page.WaitForTimeoutAsync(6000);
            await page.GoBackAsync();
            await page.WaitForTimeoutAsync(6000);
            await page.GoForwardAsync();
            await page.WaitForTimeoutAsync(6000);
            await page.GoBackAsync();
            await page.WaitForTimeoutAsync(6000);
            await page.ReloadAsync();
            await page.WaitForTimeoutAsync(6000); 
        }
    }
}