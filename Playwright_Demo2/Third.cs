using Microsoft.Playwright;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Playwright_Demo2
{
    public class Third
    {
        [Test]
        public async Task yamini()
        {
            using var play = await Playwright.CreateAsync();
            var browser = await play.Chromium.LaunchAsync(new BrowserTypeLaunchOptions { Headless = false });
            var context = await browser.NewContextAsync();
            var page = await context.NewPageAsync();
          await  page.GotoAsync("https://www.flipkart.com/");
             string b =await page.TitleAsync();
            Console.WriteLine(b);
            string c =  page.Url;

            Console.WriteLine(c);
            string d = await page.ContentAsync();
            Console.WriteLine(d);

          await  page.FillAsync("//input[@class='Pke_EE']", "Samsung Galaxy S24 FE 5G (Mint, 128 GB)  (8 GB RAM)");

           await page.PressAsync("//input[@class='Pke_EE']", "Enter");


            await page.WaitForTimeoutAsync(6000);
           await page.Locator("(//div[@class='KzDlHZ'])[1]").ClickAsync();
            await page.WaitForTimeoutAsync(6000);
          


        }


    }
}
