using Microsoft.Playwright;
using System;
using System.Collections.Generic;
using System.Formats.Tar;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.Playwright.Assertions;

namespace Playwright_Demo2
{
    internal class Multidropselectcs
    {
        [Test]
        public async Task nk()
        {
            using var play = await Playwright.CreateAsync();
            var Browser = await play.Chromium.LaunchAsync(new BrowserTypeLaunchOptions { Headless = false });


            var context = await Browser.NewContextAsync();
            var page = await context.NewPageAsync();
            await page.GotoAsync("https://testautomationpractice.blogspot.com/");
            await page.WaitForTimeoutAsync(2000);
            await page.Locator("//select[@id='colors']").ScrollIntoViewIfNeededAsync();
            await page.SelectOptionAsync("//select[@id='colors']", new[] { new SelectOptionValue { Index = 4 }, new SelectOptionValue { Index = 5 } });
            await page.WaitForTimeoutAsync(7000);

            
        }
    }
}