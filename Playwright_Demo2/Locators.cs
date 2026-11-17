using Microsoft.Playwright;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playwright_Demo2
{
   public  class Locators
    {
        [Test]
        public async Task nk()
        {
            using var play = await Playwright.CreateAsync();
            var Browser = await play.Chromium.LaunchAsync(new BrowserTypeLaunchOptions { Headless = false });


            var context = await Browser.NewContextAsync();
            var page = await context.NewPageAsync();
            await page.GotoAsync("https://testautomationpractice.blogspot.com/p/playwrightpractice.html");
            await page.WaitForTimeoutAsync(4000);
            /*   var a =  page.GetByText("List item 1");
             *   
               string b = await a.InnerTextAsync();
               Console.WriteLine(b);
               var c = page.GetByTitle("Home page link");

               string d = await c.InnerTextAsync();
               Console.WriteLine(d);
               var e = page.GetByTitle("Tooltip text");
               await e.ClickAsync();
               await page.WaitForTimeoutAsync(6000);
               var f = page.GetByPlaceholder("Enter your full name");
               await f.FillAsync("NK Naveen");
               await page.WaitForTimeoutAsync(6000);
            
            var a = page.GetByLabel("Email Address:");
            
            await a.FillAsync("nknaveen096@gmail.com");
            await page.WaitForTimeoutAsync(6000);
            var b = page.GetByLabel(" Express");
            await b.ClickAsync();  
            */
            await page.WaitForTimeoutAsync(6000);
            var c = page.GetByTitle("Home page link");
            if (c.Equals("Home page link"))

                    {

                Console.WriteLine("Yamini");
            }
            else
            {
                Console.WriteLine("NO");
            }

        }
    }
}
