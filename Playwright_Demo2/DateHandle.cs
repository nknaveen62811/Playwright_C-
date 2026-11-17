using Microsoft.Playwright;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playwright_Demo2
{
    public class DateHandle
    {

        [Test]
        public async Task nk()
        {
            using var a = await Playwright.CreateAsync();
            var b = await a.Chromium.LaunchAsync(new BrowserTypeLaunchOptions { Headless = false });
            var context = await b.NewContextAsync();
            var page = await context.NewPageAsync();

            await page.GotoAsync("https://cosmocode.io/automation-practice-webtable/");
            await page.Locator("//strong[text()='Australia']").ScrollIntoViewIfNeededAsync();
            await page.WaitForTimeoutAsync(4000);


            var bb = await page.Locator("//table[@id=\"countries\"]/tbody/tr[10]/td").AllInnerTextsAsync();
            await page.WaitForTimeoutAsync(2000);
            foreach(var text in bb)
            {
                    Console.WriteLine(text);
            }
            await page.WaitForTimeoutAsync(4000);


            int val1 = 10;
            int val2 = 20;

            if(val1<val2)
            {
                await page.CheckAsync("(//input[@class=\"hasVisited\"])[10]");
            }

            await page.WaitForTimeoutAsync(4000);
        }
    }
}

