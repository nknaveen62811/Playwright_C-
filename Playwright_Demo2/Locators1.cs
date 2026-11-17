using Microsoft.Playwright;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Playwright_Demo2
{
    public class Locators1
    {
        [Test]
        public async Task nk()
        {
            using var play = await Playwright.CreateAsync();
            var Browser = await play.Chromium.LaunchAsync(new BrowserTypeLaunchOptions { Headless = false });


            var context = await Browser.NewContextAsync();
            var page = await context.NewPageAsync();
            /*  await page.GotoAsync("https://www.google.com/");

              var a = page.GetByText("मराठी");

              await a.ClickAsync();
          //    await a.ClickAsync();
            
            await page.GotoAsync("https://www.flipkart.com/");
            var a=page.GetByPlaceholder("Search for Products, Brands and More");
            await a.FillAsync("Mobiles");
            await a.PressAsync("Enter");
            await page.WaitForTimeoutAsync(6000);
            */
           
            //  Console.WriteLine(b);
        }
    }
}
