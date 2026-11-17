using Microsoft.Playwright;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playwright_Demo2
{
    public class Alerts1
    {
        [Test]
        public async Task nk()
        {
            using var a = await Playwright.CreateAsync();
            var b = await a.Chromium.LaunchAsync(new BrowserTypeLaunchOptions { Headless = false });
            var context = await b.NewContextAsync();
            var page = await context.NewPageAsync();
            await page.GotoAsync("https://testpages.herokuapp.com/pages/basics/alerts-javascript/");
            await page.WaitForTimeoutAsync(2000);


            /*  
            page.Dialog += async (_, dialog) =>
            {
                Console.WriteLine($"Gabbu Message :{dialog.Message}");
                await dialog.AcceptAsync();
            };
            await page.ClickAsync("//button[text()='Show alert box']");
            await page.WaitForTimeoutAsync(6000);

*/


            page.Dialog += async (_, dialog) =>
            {
                Console.WriteLine($"Gabbu Message :{dialog.Message}");
                await dialog.DismissAsync();
            };
          await  page.ClickAsync("//button[text()='Show confirm box']");
            await page.WaitForTimeoutAsync(6000);

        }
    }
}