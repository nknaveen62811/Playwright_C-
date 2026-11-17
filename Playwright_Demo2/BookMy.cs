using Microsoft.Playwright;
using System;
using System.Collections.Generic;
using System.Formats.Asn1;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playwright_Demo2
{
    public class BookMy
    {
        [Test]
        public async Task nk()
        {
            using var a = await Playwright.CreateAsync();
            var b = await a.Chromium.LaunchAsync(new BrowserTypeLaunchOptions { Headless = false });
            var context = await b.NewContextAsync();
            var page = await context.NewPageAsync();

            await page.WaitForTimeoutAsync(2000);

            var Link = "file:///C:/Users/NK%20NAVEEN/OneDrive/Desktop/Dashboard_Spe.html";

           

            await page.GotoAsync(Link);
            await page.WaitForTimeoutAsync(4000);

            await page.FillAsync("//input[contains(@id,\"email\")]", "");

            await page.WaitForTimeoutAsync(2000);   
            

            await page.FillAsync("//input[contains(@id,\"password\")]", "");
            await page.WaitForTimeoutAsync(2000);



            await page.ClickAsync("//button[normalize-space()='SHOW']");

            await page.WaitForTimeoutAsync(2000);

            await page.ClickAsync("//button[text()='HIDE']");

            await page.WaitForTimeoutAsync(2000);

            await page.ClickAsync("//button[@type=\"submit\"]");

            await page.WaitForTimeoutAsync(4000);

        }
    }
}