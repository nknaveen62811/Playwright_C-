using Microsoft.Playwright;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playwright_Demo2
{
    public class Realtime
    {
        [Test]
        public async Task nk()
        {
            using var a = await Playwright.CreateAsync();
            var b = await a.Chromium.LaunchAsync(new BrowserTypeLaunchOptions { Headless = false });
            var context = await b.NewContextAsync();
            var page = await context.NewPageAsync();
            await page.GotoAsync("https://www.flipkart.com/");
            await page.WaitForTimeoutAsync(2000);


              await page.TypeAsync("//input[@name=\"q\"]", "samsung s25 ultra");
            await page.PressAsync("//input[@name=\"q\"]", "Enter");
            await page.WaitForTimeoutAsync(4000);
            await page.ClickAsync("(//div[@class=\"RG5Slk\"])[1]");
            await page.WaitForTimeoutAsync(4000);
            var pages = context.Pages;
            var childpage = pages[1];

          var bb=  await childpage.Locator("//div[text()='₹1,41,999']").InnerTextAsync();
            Console.WriteLine(bb);


            await page.WaitForTimeoutAsync(4000);

            for(var i=0;i<=5;i++)
            {
                await childpage.Keyboard.PressAsync("ArrowDown");
                await childpage.WaitForTimeoutAsync(2000);
            }
           
            await childpage.WaitForTimeoutAsync(4000);

            await childpage.ClickAsync("(//div[@class=\"lvJbLV col-12-12\"])[2]/div/ul/li[1]");


            await childpage.WaitForTimeoutAsync(4000);

            

        
          
             

        }
    }
}