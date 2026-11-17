using Microsoft.Playwright;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.ApplicationInsights.MetricDimensionNames.TelemetryContext;
using static Microsoft.Playwright.Assertions;

namespace Playwright_Demo2
{
    public class HardAssertion2
    {
        [Test]
        public async Task nk()
        {
            using var a = await Playwright.CreateAsync();
            var b = await a.Chromium.LaunchAsync(new BrowserTypeLaunchOptions { Headless = false });
            var context = await b.NewContextAsync();
            var page = await context.NewPageAsync();
            //    await page.GotoAsync("https://testautomationpractice.blogspot.com/");
            //    await page.WaitForTimeoutAsync(2000);

            //   var U =await page.TitleAsync();
            //   Console.WriteLine(U);


            //  await Expect(page).ToHaveURLAsync("https://testautomationpractice.blogspot.com/");

            //   await Expect(page).ToHaveTitleAsync("Automation Testing Practice");


            //  await Expect(page.Locator("//input[@id=\"name\"]")).ToHaveClassAsync("form-control");

            //  await Expect(page.Locator("//input[@id=\"name\"]")).ToHaveAttributeAsync("type","text");

            //   await Expect(page.Locator("//h2[text()='Tabs']")).ToHaveTextAsync("Tabs");

            //    await Expect(page.Locator("//h2[text()='Tabs']")).ToContainTextAsync("T");


            //  await Expect(page.Locator("//button[@name=\"start\"]")).ToBeVisibleAsync();


            //  await Expect(page.Locator("(//input[@name=\"gender\"])[1]")).ToHaveValueAsync("male");

            //  await page.CheckAsync("(//input[@name=\"gender\"])[1]");

            //   await Expect(page.Locator("(//input[@name=\"gender\"])[1]")).ToBeCheckedAsync();

            //  await Expect(page.Locator("(//select[@class=\"form-control\"])[1]/option")).ToHaveCountAsync(10);

            // await Expect(page.Locator("//button[@name=\"start\"]")).ToBeEnabledAsync();

            // Console.WriteLine("YES IT'S BEEN Checked");
            //  await page.FillAsync("//input[@id=\"name\"]", "NKNAVEENNN");

            //  await page.WaitForTimeoutAsync(2000);

            /*
                        await page.ScreenshotAsync(new PageScreenshotOptions
                        {
                            Path = "D:\\screenshotofplaywright\\nk56.png",

                            FullPage=true,
                        });
           


            var options = page.Locator("(//div[@class='form-group'])[4]/div//input");

            int count = await options.CountAsync();

            for (int i = 0; i < count; i++)
            {
                var element = options.Nth(i);

                // Print label text if needed
                var labelText = await element.EvaluateAsync<string>("el => el.nextSibling.textContent.trim()");
                Console.WriteLine(labelText);

                await element.CheckAsync();
                await page.WaitForTimeoutAsync(1000);
            }
             */
            //   await page.GotoAsync("https://accounts.google.com/v3/signin/identifier?authuser=0&continue=https%3A%2F%2Fmail.google.com%2Fmail%2F&ec=GAlAFw&hl=en&service=mail&flowName=GlifWebSignIn&flowEntry=AddSession&dsh=S-1557654614%3A1765855884341920");
            await page.GotoAsync("https://www.flipkart.com/");
            await page.WaitForTimeoutAsync(2000);

            await page.Keyboard.PressAsync("PageDown");

            await page.WaitForTimeoutAsync(2000);


            await Expect(page.Locator("(//div[@class=\"ykJuJZ\"])[1]/following::a")).ToHaveCountAsync(31);

            var A =await page.Locator("(//div[@class=\"ykJuJZ\"])[1]/following::a").AllInnerTextsAsync();
            foreach(var item in A)
            {
                Console.WriteLine(item);

            }

            await page.WaitForTimeoutAsync(4000);

        }
    }
}