using Microsoft.Playwright;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playwright_Demo2
{
    public class Window5
    {
        [Test]
        public async Task nk()
        {
            using var a = await Playwright.CreateAsync();
            var b = await a.Chromium.LaunchAsync(new BrowserTypeLaunchOptions { Headless = false });
            var context = await b.NewContextAsync();
            var page = await context.NewPageAsync();
            await page.GotoAsync("https://www.flipkart.com/");
            await page.WaitForTimeoutAsync(4000);
            await page.HoverAsync("(//div[@class=\"YBLJE4\"])[3]");
            await page.WaitForTimeoutAsync(4000);
            await page.HoverAsync("(//a[@class=\"_3490ry\"])[10]");
            await page.WaitForTimeoutAsync(2000);
            await page.ClickAsync("(//a[@class=\"_3490ry\"])[10]");
            await page.WaitForTimeoutAsync(4000);
            await page.Locator("(//div[text()='PETER ENGLAND'])[1]").ScrollIntoViewIfNeededAsync();
            await page.WaitForTimeoutAsync(2000);
            await page.ClickAsync("(//a[@title=\"Men Tuxedo Style Checkered Suit\"])[1]");
            await page.WaitForTimeoutAsync(4000);

            var pages = context.Pages;
            var child = pages.Last();
            var value = child.Locator("//span[text()='Men Tuxedo Style Checkered Suit']");
            var Res =await value.InnerTextAsync();
            Console.WriteLine(Res);
            await child.WaitForTimeoutAsync(4000);
            await child.ReloadAsync();
            await child.WaitForTimeoutAsync(7000);

            if (Res == "Men Tuxedo Style Checkered Suit") 
            {
                 Console.WriteLine("BOTH ARE MACHING PERFECTLYYYYYYY");
            }
            else
            {
                Console.WriteLine("bbbbbbbbbbbbbb");
            }
            
        }
    }
}