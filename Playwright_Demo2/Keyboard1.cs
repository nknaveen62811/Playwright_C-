using Microsoft.Playwright;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playwright_Demo2
{
    public class Keyboard1
    {

        [Test]
        public async Task nk()
        {
            using var a = await Playwright.CreateAsync();
            var b = await a.Chromium.LaunchAsync(new BrowserTypeLaunchOptions { Headless = false });
            var context = await b.NewContextAsync();
            var page = await context.NewPageAsync();
            await page.GotoAsync("https://www.hyrtutorials.com/p/basic-controls.html");
            await page.WaitForTimeoutAsync(2000);
            await page.TypeAsync("//input[@id=\"firstName\"]", "Naveen");
            await page.WaitForTimeoutAsync(2000);
            await page.TypeAsync("//input[@id=\"lastName\"]", "NK");

            await page.Locator("(//input[@name=\"gender\"])[1]").ScrollIntoViewIfNeededAsync();
          
                await page.CheckAsync("(//input[@name=\"gender\"])[1]");
                await page.WaitForTimeoutAsync(2000);

            await page.CheckAsync("//input[@id=\"englishchbx\"]");
            await page.WaitForTimeoutAsync(2000);
            await page.FillAsync("//input[@id=\"email\"]", "nknaveen094@gmail.com");
            await page.WaitForTimeoutAsync(2000);
            await page.FillAsync("//input[@id=\"password\"]", "nknaveen@123");
            await page.WaitForTimeoutAsync(2000);
            await page.ClickAsync("//button[@id=\"registerbtn\"]");
            await page.WaitForTimeoutAsync(7000);
        }
    }
}