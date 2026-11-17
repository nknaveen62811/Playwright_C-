using Microsoft.Playwright;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playwright_Demo2
{
    public class Mouseactions
    {
        [Test]
        public async Task nk()
        {
            using var a = await Playwright.CreateAsync();
            var b = await a.Chromium.LaunchAsync(new BrowserTypeLaunchOptions { Headless = false });
            var context = await b.NewContextAsync();
            var page = await context.NewPageAsync();
            await page.GotoAsync("https://testautomationpractice.blogspot.com/");
            await page.WaitForTimeoutAsync(3000);
            //   await page.Locator("//button[text()='Copy Text']").DblClickAsync();

            
            await page.DblClickAsync("//button[text()='Copy Text']");

            await page.WaitForTimeoutAsync(7000);
            await page.HoverAsync("//button[text()='Point Me']");
            await page.WaitForTimeoutAsync(2000);
          await  page.HoverAsync("//a[text()='Mobiles']");
            await page.WaitForTimeoutAsync(2000);
          await page.ClickAsync("//a[text()='Mobiles']");
            await page.WaitForTimeoutAsync(7000);
            await page.ClickAsync("//input[@id='name']");
            await page.TypeAsync("//input[@id='name']", "NK Naveen");
            string aa = await page.InputValueAsync("//input[@id='name']");
            Console.WriteLine(aa);



/*
            await page.HoverAsync("//a[text()='Laptops']");
            await page.WaitForTimeoutAsync(4000);
*/

        }
    }


}