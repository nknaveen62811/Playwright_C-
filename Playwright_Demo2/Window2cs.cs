using Microsoft.Playwright;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playwright_Demo2
{
    public class Window2cs
    {
        [Test]
        public async Task nk()
        {
            using var play = await Playwright.CreateAsync();
            var Browser = await play.Chromium.LaunchAsync(new BrowserTypeLaunchOptions { Headless = false });


            var context = await Browser.NewContextAsync();
            var page = await context.NewPageAsync();
            await page.GotoAsync("https://www.hyrtutorials.com/");
            await page.WaitForTimeoutAsync(4000);
            await page.HoverAsync("//a[text()='Selenium Practice']");
            await page.WaitForTimeoutAsync(2000);
            await page.HoverAsync("//a[text()='Window Handles']");
            await page.ClickAsync("//a[text()='Window Handles']");
            await page.WaitForTimeoutAsync(4000);
            await page.ClickAsync("//button[@id='newWindowBtn']");
            await page.WaitForTimeoutAsync(2000);

           /* var pag = context.Pages;
           //  await pag[1].BringToFrontAsync();
            var child = pag[1];
            await child.BringToFrontAsync();

            await child.WaitForTimeoutAsync(2000);
            await child.Locator("//li[text()='Textbox']").ScrollIntoViewIfNeededAsync();
            await child.WaitForTimeoutAsync(2000);

            var ele = child.Locator("//li[text()='Textbox']");
            string elem = await ele.InnerTextAsync();
            */
            var pag = context.Pages;
      
            await pag[1].BringToFrontAsync();

            await pag[1].WaitForTimeoutAsync(2000);
            await pag[1].Locator("//ul[@style='text-align: left;']").ScrollIntoViewIfNeededAsync();
            await pag[1].WaitForTimeoutAsync(2000);

            var ele = pag[1].Locator("//ul[@style='text-align: left;']");
            string elem = await ele.InnerTextAsync();

            Console.WriteLine(elem);
            await pag[1].WaitForTimeoutAsync(4000);


        }
        }
}
