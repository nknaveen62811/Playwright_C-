using Microsoft.Playwright;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playwright_Demo2
{
    public class Eventscs
    {
        [Test]
        public async Task nk()
        {
            using var a = await Playwright.CreateAsync();
            var b = await a.Chromium.LaunchAsync(new BrowserTypeLaunchOptions { Headless = false });
            var context = await b.NewContextAsync();
            var page = await context.NewPageAsync();
            await page.GotoAsync("https://www.hyrtutorials.com/");
            page.Request += (_, request) =>
            {
                Console.WriteLine("Request: " + request.Url);
            };
           await page.WaitForTimeoutAsync(4000);

            page.Response += (_, response) =>
            {
                Console.WriteLine("Response: " + response.Url);
            };
            await page.WaitForTimeoutAsync(10000);
        }
    }
}
