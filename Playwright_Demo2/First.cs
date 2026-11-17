using Microsoft.Playwright;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playwright_Demo2
{
    public class First
    {
        [Test]
        public async Task nk()
        {
            using var play = await Playwright.CreateAsync();
            var browser = await play.Chromium.LaunchAsync(new BrowserTypeLaunchOptions { Headless = false });
            var context = await browser.NewContextAsync();
            var page = await context.NewPageAsync();
         await  page.GotoAsync("https://www.flipkart.com/");
            await page.WaitForTimeoutAsync(2000);
            Console.WriteLine("NKKKKKK");
            await page.TypeAsync("//input[@type='text']", "Samsung Galaxy S24 FE 5G (Mint, 128 GB)  (8 GB RAM)");
            await page.PressAsync("//input[@type='text']", "Enter");
            
            await page.WaitForTimeoutAsync(6000);
          var a=  page.Locator("(//div[@class='zg-M3Z'])[1]");
            string b =await a.TextContentAsync();
            Console.WriteLine(b);
          await  page.Locator("(//div[@class='KzDlHZ'])[1]").ClickAsync();
            await page.WaitForTimeoutAsync(6000);
            await page.GoBackAsync();
            await page.WaitForTimeoutAsync(6000);
       
            await page.CloseAsync();
        }
    }
}
