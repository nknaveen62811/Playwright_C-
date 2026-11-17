using Microsoft.Playwright;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playwright_Demo2
{
    public class Sceenshot
    {
        [Test]
        
        public async Task Screenshot()
        {

            using var play = await Playwright.CreateAsync();
            var bro = await play.Chromium.LaunchAsync(new BrowserTypeLaunchOptions { Headless = false });
            var context = await bro.NewContextAsync();
            var page = await context.NewPageAsync();
            await page.GotoAsync("https://www.hyrtutorials.com/");
            await page.WaitForTimeoutAsync(2000);
            await page.ScreenshotAsync(new PageScreenshotOptions
            {
                Path = "D:\\screenshotofplaywright\\nk2.png",
                FullPage=true
            });
            var a = page.Locator("//div[@class=\"body-row menu-wrap\"]");
            await a.ScreenshotAsync(new LocatorScreenshotOptions
            {
                Path = "D:\\screenshotofplaywright\\nk3.png",
            });

        }
       

    }
}
