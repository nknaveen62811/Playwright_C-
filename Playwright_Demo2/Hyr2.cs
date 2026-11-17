using Microsoft.Playwright;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playwright_Demo2
{
    public class Hyr2
    {

        [Test]
        public async Task nk()
        {
            using var a = await Playwright.CreateAsync();
            var b = await a.Chromium.LaunchAsync(new BrowserTypeLaunchOptions { Headless = false });
            var context = await b.NewContextAsync();
            var page = await context.NewPageAsync();

            await page.GotoAsync("https://www.hyrtutorials.com/");
            await page.WaitForTimeoutAsync(2000);
            await page.HoverAsync("//a[text()='Selenium Practice']");
            await page.HoverAsync("//a[text()='Window Handles']");
            await page.ClickAsync("//a[text()='Window Handles']");
            await page.WaitForTimeoutAsync(4000);
            await page.Locator("//button[@id=\"newWindowsBtn\"]").ScrollIntoViewIfNeededAsync();
            await page.WaitForTimeoutAsync(2000);
            await page.ClickAsync("//button[@id=\"newWindowsBtn\"]");
            await page.WaitForTimeoutAsync(4000);


            var pages = context.Pages;


            await pages[1].Locator("//input[@id=\"firstName\"]").ScrollIntoViewIfNeededAsync();
            await pages[1].FillAsync("//input[@id=\"firstName\"]", "mkjih");
            await pages[2].ClickAsync("//select[@id=\"selectnav2\"]");
            await pages[2].WaitForTimeoutAsync(4000);
            var title = await pages[1].TitleAsync();
            var title2 = await pages[2].TitleAsync();
            Console.WriteLine(title );
            Console.WriteLine(title2);
            if(title!=title2)
            {
                pages[0].ClickAsync("//img[@id=\"Header1_headerimg\"]");
            }
            else
            {
                Console.WriteLine("....");
            }
            await page.WaitForTimeoutAsync(7000);
        }
    }
}