using Microsoft.Playwright;
using Microsoft.VisualStudio.TestPlatform.CommunicationUtilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playwright_Demo2
{
    public class Assertions
    {


       [Test]
        public async Task nk()
        {
            using var play = await Playwright.CreateAsync();
            var Browser = await play.Chromium.LaunchAsync(new BrowserTypeLaunchOptions { Headless = false });


            var context = await Browser.NewContextAsync();
            var page = await context.NewPageAsync();
            await page.GotoAsync("https://www.demoblaze.com/index.html");

            page.Locator("//a[contains(@id,\"login2\")]").ClickAsync();
            await page.WaitForTimeoutAsync(2000);

            page.TypeAsync("//input[@id=\"loginusername\"]", "Nknaveen096");
            await page.WaitForTimeoutAsync(2000);

            page.TypeAsync("//input[@id=\"loginpassword\"]", "nknaveen@123");
            await page.WaitForTimeoutAsync(2000);
            page.Locator("//button[text()='Log in']").ClickAsync();
            await page.WaitForTimeoutAsync(4000);

            for(var i = 1; i < 10; i++)
            {

                page.Keyboard.PressAsync("ArrowDown");
                await page.WaitForTimeoutAsync(1000);
            }
            await page.Keyboard.PressAsync("PageUp");

            await page.WaitForTimeoutAsync(4000);
            await page.ClickAsync("//a[text()='Nokia lumia 1520']");
            await page.WaitForTimeoutAsync(8000);
            await page.ClickAsync("//a[text()='Add to cart']");
            await page.WaitForTimeoutAsync(4000);
            await page.GoBackAsync();
            await page.WaitForTimeoutAsync(4000);

        }
    }
}
