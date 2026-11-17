using Microsoft.Playwright;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playwright_Demo2
{
    internal class HardAssertion
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
            await page.Locator("//span[text()='Fashion']").HoverAsync();
            await page.WaitForTimeoutAsync(2000);
            await page.ClickAsync("//span[text()='Fashion']");
            await page.WaitForTimeoutAsync(4000);


            await page.HoverAsync("(//span[@class=\"OqYNhN\"])[7]");

            await page.WaitForTimeoutAsync(2000);


       var values=     await page.Locator("//div[@class=\"GPtm5l\"]/div[5]/a").AllInnerTextsAsync();


             foreach( var s in values )
            {
                Console.WriteLine(s);
            }


            await page.ClickAsync("//div[@class=\"GPtm5l\"]/div[5]/a[4]");
            await page.WaitForTimeoutAsync(7000);
            /*
                  var U=page.Url;
                        Console.WriteLine(U);

                        if(U.Equals("https://www.flipkart.com/gaming/gaming-consoles/pr?sid=4rr,x1m&otracker=nmenu_sub_Sports%2C%20Books%20%26%20More_0_Gaming%20Consoles&otracker=nmenu_sub_Sports%2C%20Books%20%26%20More_0_Gaming%20Consoles"))
                        {
                            await page.GoBackAsync();
                            await page.WaitForTimeoutAsync(7000);

                        }
            */

           var T=await page.TitleAsync();
            Console.WriteLine(T);
            if(T.Equals("Gaming Consoles Online in India at Best Prices"))
            {
               
                for(int i=0; i<=10;i++)
                {
                    page.Keyboard.PressAsync("ArrowDown");
                    await page.WaitForTimeoutAsync(2000);
                }
                if (T.Equals("https://www.flipkart.com/gaming/gaming-consoles/pr?sid=4rr,x1m&otracker=nmenu_sub_Sports%2C%20Books%20%26%20More_0_Gaming%20Consoles&otracker=nmenu_sub_Sports%2C%20Books%20%26%20More_0_Gaming%20Consoles")) ;
                {
                    var UU = await page.ContentAsync();
                    Console.WriteLine(UU);
                }

            }
        }
    }
}