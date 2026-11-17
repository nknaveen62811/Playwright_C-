using Microsoft.Playwright;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playwright_Demo2
{
    public class Customdropdown
    {
        [Test]
        public async Task nk()
        {
            using var play = await Playwright.CreateAsync();
            var Browser = await play.Chromium.LaunchAsync(new BrowserTypeLaunchOptions { Headless = false });


            var context = await Browser.NewContextAsync();
            var page = await context.NewPageAsync();

            string Url = "https://accounts.google.com/v3/signin/identifier?authuser=0&continue=https%3A%2F%2Fmail.google.com%2Fmail%2F&ec=GAlAFw&hl=en&service=mail&flowName=GlifWebSignIn&flowEntry=AddSession&dsh=S809040770%3A1779867925910302";


            await page.GotoAsync(Url);


            var Email=  await page.Locator("//ul[@class=\"VfPpkd-rymPhb r6B9Fd bwNLcf P2Hi5d VfPpkd-OJnkse\"]/li").AllInnerTextsAsync();

           

            foreach (var tags in Email)
            {

              Console.WriteLine(tags);

            }

        }
    }
}
