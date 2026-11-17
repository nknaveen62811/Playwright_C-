using Microsoft.Playwright;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Playwright_Demo2
{
    public class Autosuggestion
    {

        [Test]
        public async Task nk()
        {
            using var play = await Playwright.CreateAsync();
            var Browser = await play.Chromium.LaunchAsync(new BrowserTypeLaunchOptions { Headless = false });


            var context = await Browser.NewContextAsync();
            var page = await context.NewPageAsync();



            List<string> urls = new List<string>
            {

                "https://www.google.com/?zx=1774592508981&no_sw_cr=1","file:///C:/Users/NK%20NAVEEN/OneDrive/Desktop/Apps.html"
,"https://www.hyrtutorials.com/p/alertsdemo.html","https://www.demoblaze.com/#"

            };

           foreach (var url in urls)
            {
                await page.GotoAsync(url);
                await page.WaitForTimeoutAsync(4000);
                var title = await page.ContentAsync();
                Console.WriteLine(title);
            }
            await page.WaitForTimeoutAsync(2000);
        }
    }
}