using Microsoft.Playwright;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playwright_Demo2
{
    public class Rightclick
    {
        [Test]
        public async Task nk()
        {
            using var a = await Playwright.CreateAsync();
            var b = await a.Chromium.LaunchAsync(new BrowserTypeLaunchOptions { Headless = false });
            var context = await b.NewContextAsync();
            var page = await context.NewPageAsync();
            /*   await page.GotoAsync("https://www.testautomationstudio.com/demo/actions/");
               await page.WaitForTimeoutAsync(2000);
               await page.ClickAsync("//input[@id='action3']" ,new() { Button = MouseButton.Right });


               await page.WaitForTimeoutAsync(6000);
            */
            await page.GotoAsync("https://testautomationpractice.blogspot.com/");
            await page.WaitForTimeoutAsync(2000);
            await page.ClickAsync("//input[@id='field2']", new() { Button = MouseButton.Right });
            await page.WaitForTimeoutAsync(6000);
        }
    }
}