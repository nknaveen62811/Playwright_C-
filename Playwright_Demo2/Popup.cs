using Microsoft.Playwright;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playwright_Demo2
{
    public class Popup
    {


        [Test]
        public async Task nk()
        {
            using var a = await Playwright.CreateAsync();
            var b = await a.Chromium.LaunchAsync(new BrowserTypeLaunchOptions { Headless = false });
            var context = await b.NewContextAsync();
            var page = await context.NewPageAsync();
            await page.GotoAsync("https://accounts.google.com/v3/signin/identifier?authuser=0&continue=https%3A%2F%2Fmail.google.com%2Fmail&ec=GAlAFw&hl=en&service=mail&flowName=GlifWebSignIn&flowEntry=AddSession&dsh=S-2076380154%3A1775216695190789");
            await page.WaitForTimeoutAsync(2000);
            await page.ClickAsync("//div[@class=\"VfPpkd-aPP78e\"]");
            await page.WaitForTimeoutAsync(2000);
            await page.ClickAsync("//span[text()='తెలుగు']/parent::span/parent::li");
            await page.WaitForTimeoutAsync(4000);

            var alll = await page.Locator("//span[text()='తెలుగు']/parent::span/parent::li/parent::ul/li").AllInnerTextsAsync();

            int c = 0;
            foreach (var text in alll)
            {
               
                Console.WriteLine(text);
              
                
            }


            await page.TypeAsync("//input[@type=\"email\"]","nknaveen7880@gmail.com");
            await page.WaitForTimeoutAsync(2000);
            await page.ClickAsync("//span[text()='తదుపరి']/parent::button");
            await page.WaitForTimeoutAsync(4000);

            
        }
    }
}