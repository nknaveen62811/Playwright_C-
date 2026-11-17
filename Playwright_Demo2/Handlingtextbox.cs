using Microsoft.Playwright;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playwright_Demo2
{
    public class Handlingtextbox
    {

        [Test]
        public async Task nk()
        {
            using var a = await Playwright.CreateAsync();
            var b = await a.Chromium.LaunchAsync(new BrowserTypeLaunchOptions { Headless = false });
            var context = await b.NewContextAsync();
            var page = await context.NewPageAsync();
            await page.GotoAsync("https://www.flipkart.com/");
            await page.Locator("//input[@class='Pke_EE']").FillAsync("Mobiles");
            string aa = await page.InputValueAsync("//input[@class='Pke_EE']");
            Console.WriteLine("Value from the flipkart is :" + aa);
            await page.PressAsync("//input[@class='Pke_EE']", "Enter");
            await page.WaitForTimeoutAsync(6000);
            await page.GoBackAsync();
            await page.WaitForTimeoutAsync(6000);



        }
    }
}