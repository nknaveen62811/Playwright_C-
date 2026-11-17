using Microsoft.Playwright;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playwright_Demo2
{
    public class Samsung
    {
        [Test]
        public async Task nk()
        {
            using var play = await Playwright.CreateAsync();
            var Browser = await play.Chromium.LaunchAsync(new BrowserTypeLaunchOptions { Headless = false });


            var context = await Browser.NewContextAsync();
            var page = await context.NewPageAsync();
            await page.GotoAsync("https://www.flipkart.com/");
            await page.WaitForTimeoutAsync(2000);
            await page.TypeAsync("//input[@name=\"q\"]", "Samsung S25 Ultra ");
            await page.WaitForTimeoutAsync(2000);
            await page.PressAsync("//input[@name=\"q\"]", "Enter");
            await page.WaitForTimeoutAsync(2000);
            await page.ClickAsync("//div[text()='Samsung Galaxy S25 Ultra 5G (Titanium Silverblue, 512 GB)']");
            await page.WaitForTimeoutAsync(2000);



            var pag = context.Pages;
            var childpage = pag[1];
            await childpage.ClickAsync("//button[@class=\"dSM5Ub ugg2XR IUmgrZ\"]");
            await childpage.WaitForTimeoutAsync(8000);
        }
    }
}