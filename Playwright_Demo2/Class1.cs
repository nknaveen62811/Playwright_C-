using Microsoft.Playwright;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playwright_Demo2
{
    public class Class1
    {

        [Test]
        public async Task nk()
        {
            using var a = await Playwright.CreateAsync();
            var b = await a.Chromium.LaunchAsync(new BrowserTypeLaunchOptions { Headless = false });
            var context = await b.NewContextAsync();
            var page = await context.NewPageAsync();
            await page.GotoAsync("https://cosmocode.io/automation-practice-webtable/");
            await page.WaitForTimeoutAsync(2000);
            await page.ClickAsync("//strong[text()='Argentina']/preceding::input[@type=\"checkbox\"][1]");
            await page.WaitForTimeoutAsync(4000);
       var bb=     await page.Locator("//table[@id=\"countries\"]/tbody/tr/td").AllInnerTextsAsync();
            foreach (var text in bb)
            {
                    Console.WriteLine(text);
            }
        }
    }
}