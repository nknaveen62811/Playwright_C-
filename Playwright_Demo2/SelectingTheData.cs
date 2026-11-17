using Microsoft.Playwright;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playwright_Demo2
{
    public class SelectingTheData
    {

        [Test]
        public async Task nk()
        {
            using var a = await Playwright.CreateAsync();
            var b = await a.Chromium.LaunchAsync(new BrowserTypeLaunchOptions { Headless = false });
            var context = await b.NewContextAsync();
            var page = await context.NewPageAsync();
            await page.GotoAsync("https://testautomationpractice.blogspot.com/");
            await page.WaitForTimeoutAsync(2000);

            var val = await page.Locator("//select[@id=\"country\"]/option").AllInnerTextsAsync();
            foreach(var i in val)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine(val);

        }
    }
}