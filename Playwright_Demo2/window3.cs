using Microsoft.Playwright;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playwright_Demo2
{
    public class window3
    {
        [Test]
        public async Task nk()
        {
            using var play = await Playwright.CreateAsync();
            var Browser = await play.Chromium.LaunchAsync(new BrowserTypeLaunchOptions { Headless = false });


            var context = await Browser.NewContextAsync();
            var page = await context.NewPageAsync();
            await page.GotoAsync("https://www.hyrtutorials.com/");
            await page.WaitForTimeoutAsync(4000);
            await page.HoverAsync("//a[text()='Selenium Practice']");
            await page.WaitForTimeoutAsync(2000);
            await page.HoverAsync("//a[text()='Window Handles']");
            await page.ClickAsync("//a[text()='Window Handles']");
            await page.WaitForTimeoutAsync(4000);
            await page.Locator("//button[@id='newTabBtn']").ClickAsync();
            await page.WaitForTimeoutAsync(4000);
            var ele = context.Pages;
            var child = ele[1];

            await child.BringToFrontAsync();

            await child.WaitForTimeoutAsync(2000);
            child.ClickAsync("//button[@id='alertBox']");
            await child.WaitForTimeoutAsync(7000);
        }
    }
}