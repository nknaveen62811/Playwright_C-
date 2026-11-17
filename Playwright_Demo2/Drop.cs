using Microsoft.Playwright;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Playwright_Demo2
{
    public class Drop
    {
        [Test]
        public async Task nk()
        {
            using var a = await Playwright.CreateAsync();
            var b = await a.Chromium.LaunchAsync(new BrowserTypeLaunchOptions { Headless = false });
            var context = await b.NewContextAsync();
            var page = await context.NewPageAsync();
            await page.GotoAsync("https://testautomationpractice.blogspot.com/");
            await page.WaitForTimeoutAsync(3000);
            // await page.SelectOptionAsync("//select[@id='country']", "japan");
            //  await page.WaitForTimeoutAsync(7000);
            //   await page.SelectOptionAsync("//select[@id=\"country\"]", "uk");
            await page.Locator("//select[@id=\"country\"]").ScrollIntoViewIfNeededAsync();
               
            await page.SelectOptionAsync("//select[@id=\"country\"]", new SelectOptionValue { Value="uk"});
            await page.WaitForTimeoutAsync(3000);
            await page.SelectOptionAsync("//select[@id=\"country\"]", new SelectOptionValue { Label = "France" });
            await page.WaitForTimeoutAsync(3000);
            await page.SelectOptionAsync("//select[@id=\"country\"]", new SelectOptionValue { Index = 6 }); 
            await page.WaitForTimeoutAsync(7000);
        }
    }
}