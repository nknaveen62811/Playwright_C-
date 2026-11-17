using Microsoft.Playwright;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.XPath;

namespace Playwright_Demo2
{
    public class Alerts3
    {
        [Test]
        public async Task nk()
        {
            using var a = await Playwright.CreateAsync();
            var b = await a.Chromium.LaunchAsync(new BrowserTypeLaunchOptions { Headless = false });
            var context = await b.NewContextAsync();
            var page = await context.NewPageAsync();
            await page.GotoAsync("https://www.tutorialspoint.com/selenium/practice/alerts.php");
            page.Dialog += async (_, dialog) =>
            {

                Console.WriteLine($"Gabbu  message :{dialog.Message}");
                await dialog.AcceptAsync();
            };
        var u=    page.Locator("(//button[@class='btn btn-primary'])[1]");
            await u.ClickAsync();
            var v = page.Locator("//label[text()='Click Button to see alert']");
            string j = await v.InnerTextAsync();
            Console.WriteLine(j);

        }
    }
}