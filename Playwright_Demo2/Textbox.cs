using Microsoft.Playwright;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playwright_Demo2
{
    public class Textbox
    {
        [Test]
        public async Task nk()
        {
            using var play = await Playwright.CreateAsync();
            var browser = await play.Chromium.LaunchAsync(new BrowserTypeLaunchOptions { Headless = false });
            var context = await browser.NewContextAsync();
            var page = await context.NewPageAsync();
            await page.GotoAsync("https://www.flipkart.com/");
            //way one to fill the Textbox
           await page.Locator("//input[@class='Pke_EE']").FillAsync("Samsung mobiles");
          //  await page.PressAsync("//input[@class='Pke_EE']", "Enter");

            //way 2 to fill the Textbox
            // await page.FillAsync("//input[@class='Pke_EE']", "Samsung mobiles");

            //way 3 to fill the Textbox
          //  await page.TypeAsync("//input[@class='Pke_EE']", "Samsung Mobiles");
            await page.WaitForTimeoutAsync(6000);
            await page.FillAsync("//input[@class='Pke_EE']", "");  // Note in only Faillasync only we can give "" to clear the text field.
            await page.WaitForTimeoutAsync(6000);

        }
    }
}