using Microsoft.Playwright;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playwright_Demo2
{
    public class DatePickercs
    {
        [Test]
        public async Task nk()
        {
            using var a = await Playwright.CreateAsync();
            var b = await a.Chromium.LaunchAsync(new BrowserTypeLaunchOptions { Headless = false });
            var context = await b.NewContextAsync();
            var page = await context.NewPageAsync();


            await page.GotoAsync("https://testautomationpractice.blogspot.com/");
            await page.WaitForTimeoutAsync(4000);
            await page.Locator("//select[@id=\"animals\"]").ScrollIntoViewIfNeededAsync();
            await page.WaitForTimeoutAsync(4000);
            await page.Locator("//input[@id=\"datepicker\"]").ClickAsync();
            await page.WaitForTimeoutAsync(4000);

            for (var i = 1; i <=11; i++)
            {
                var titles = await page.Locator("//span[@class=\"ui-datepicker-month\"]").InnerTextAsync();
                Console.WriteLine(titles);


                await page.ClickAsync("//a[@title=\"Next\"]");

            }
            await page.WaitForTimeoutAsync(4000);

            int ac = 10;
            if (ac == 10)
            {
                await page.ClickAsync("(//a[@class=\"ui-state-default\"])[2]");
            }
            await page.WaitForTimeoutAsync(4000);

            await page.ClickAsync("//input[@id=\"txtDate\"]");
            await page.WaitForTimeoutAsync(2000);

            var ad = await page.Locator("//select[@class=\"ui-datepicker-month\"]/option").AllInnerTextsAsync();
            await page.WaitForTimeoutAsync(2000);
            foreach (var text in ad)
            {
                Console.WriteLine(text);
            }
            await page.WaitForTimeoutAsync(2000);
            if (ac == 10)
            {
                await page.SelectOptionAsync("//select[@class=\"ui-datepicker-month\"]", new SelectOptionValue { Value="0" });
            }
            await page.WaitForTimeoutAsync(4000);
        }
    }
}
