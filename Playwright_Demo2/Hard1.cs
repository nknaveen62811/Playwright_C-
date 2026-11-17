using Microsoft.Playwright;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.Playwright.Assertions;


namespace Playwright_Demo2
{
    public class Hard1
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
            // await Expect(page.Locator("(//div[@class=\"_38VF5e\"])[3]/a[1]")).ToBeVisibleAsync();


            //   await Expect(page.Locator("//span[text()='Fashion']")).ToHaveTextAsync("Fashi");

            //  await Expect(page.Locator("//span[text()='Fashion']")).ToContainTextAsync("Fa");

            // await Expect(page.Locator("(//input[@type=\"radio\"])[1]")).ToHaveValueAsync("male");
            //  await Expect(page.Locator("//input[@id=\"name\"]")).ToHaveClassAsync("form-control");


            // await Expect(page.Locator("//input[@id=\"name\"]")).ToHaveAttributeAsync("type", "text");




            // await page.CheckAsync("//input[@id=\"sunday\"]");


            //  await Expect(page.Locator("//input[@id=\"sunday\"]")).ToBeCheckedAsync();



            //  await Expect(page.Locator("//select[@id=\"country\"]/option")).ToHaveCountAsync(10);

            //  await Expect(page.Locator("//button[@id=\"alertBtn\"]")).ToBeEnabledAsync();






            //    await Expect(page.Locator("//input[@id=\"name\"]")).ToBeHiddenAsync();


            var U = page.Url;
            Console.WriteLine(U);

            //  await Expect(page).ToHaveTitleAsync("Automation Testing Practice");
            // Console.WriteLine("Element is visible");
            await Expect(page).ToHaveURLAsync("https://testautomationpractice.blogspot.com/");
            Console.WriteLine("Element is visible");
            await page.WaitForTimeoutAsync(4000);

        }
    }
}