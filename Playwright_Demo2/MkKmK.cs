using Microsoft.Playwright;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playwright_Demo2
{
    public class MkKmK
    {
        [Test]
        public async Task nk()
        {
            using var play = await Playwright.CreateAsync();
            var Browser = await play.Chromium.LaunchAsync(new BrowserTypeLaunchOptions { Headless = false });


            var context = await Browser.NewContextAsync();
            var page = await context.NewPageAsync();
            var url = "https://accounts.google.com/v3/signin/identifier?authuser=0&continue=https%3A%2F%2Fmail.google.com%2Fmail&ec=GAlAFw&hl=en&service=mail&flowName=GlifWebSignIn&flowEntry=AddSession&dsh=S-149308339%3A1764860994330672";
            await page.GotoAsync(url);
            await page.WaitForTimeoutAsync(2000);
           
           


          

            var elements =await page.Locator("//div[@class=\"VfPpkd-aPP78e\"]/following::div[1]/ul/span/following::li").AllInnerTextsAsync();

            await page.WaitForTimeoutAsync(4000);

            foreach (var y in elements) 
            {
                Console.WriteLine(y);
            }

            await page.WaitForTimeoutAsync(2000);

        }
    }
}