using Microsoft.Playwright;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playwright_Demo2
{
    public class Amazoncs
    {
        [Test]
        public async Task nk()
        {
            using var a = await Playwright.CreateAsync();
            var b = await a.Chromium.LaunchAsync(new BrowserTypeLaunchOptions { Headless = false });
            var context = await b.NewContextAsync();
            var page = await context.NewPageAsync();
            await page.WaitForTimeoutAsync(2000);

            string url = "https://www.nykaafashion.com/international/designers/mochi/c/4382?utm_content=ads&utm_source=GooglePaid&utm_medium=PLA&utm_campaign=Search_AiMax_Catchall_RSA&gad_source=1&gad_campaignid=23748759038&gbraid=0AAAAAC968R1V_TPaTsutuC8AyfVjO2q51&gclid=CjwKCAjwl97RBhBWEiwAa9rbXWOkvFlPdcu7LUmes61PF1bpgKw-ESPAgdIRg7waptT7I8Rc4IVx0RoCcC4QAvD_BwE";


            await page.GotoAsync(url);


            await page.WaitForTimeoutAsync(2000);


            int A1 = 10;
            int A2 = 20;


            if(A1==20)
            {

                await page.HoverAsync("//span[text()='Women']");
               
            }
            else
            {
                await page.HoverAsync("//span[text()='Men']");  

                await page.WaitForTimeoutAsync(2000);
                await page.HoverAsync("//div[text()='Sale']");
                await page.WaitForTimeoutAsync(4000);

                await page.ClickAsync("//a[text()='View All']");

            }
            await page.WaitForTimeoutAsync(8000);

        }

    }
}