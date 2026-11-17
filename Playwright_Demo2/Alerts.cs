using Microsoft.Playwright;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playwright_Demo2
{
    public class Alerts
    {

        [Test]
        public async Task nk()
        {
            using var a = await Playwright.CreateAsync();
            var b = await a.Chromium.LaunchAsync(new BrowserTypeLaunchOptions { Headless = false });
            var context = await b.NewContextAsync();
            var page = await context.NewPageAsync();
            await page.GotoAsync("https://testkru.com/Interactions/Alerts");
            await page.WaitForTimeoutAsync(2000);
            page.Dialog += async (_, dialog) =>
            {
                /*Console.WriteLine($"Alert message: {dialog.Message}");
                 
                The $ in front of the string ($"...") is called string interpolation in C#.
               It allows you to insert variables or expressions directly inside a string.
                 
                 */



                Console.WriteLine("Alert message: " + dialog.Message);
                await dialog.AcceptAsync("NK Yamini");
                await page.WaitForTimeoutAsync(6000);
            };
            await page.ClickAsync("//button[text()='Show Prompt']");
            await page.WaitForTimeoutAsync(6000);

           



            page.Dialog += async (_, dialog) =>
            {
                // Console.WriteLine($"Alert message: {dialog.Message}");
                Console.WriteLine("Alert message: " + dialog.Message);
                await dialog.AcceptAsync();
                await page.WaitForTimeoutAsync(6000);
            };


            await page.ClickAsync("//button[text()='Show Alert']");
            await page.WaitForTimeoutAsync(6000);



            page.Dialog += async (_, dialog) =>
            {
                // Console.WriteLine($"Alert message: {dialog.Message}");
                Console.WriteLine("Alert message: " + dialog.Message);
                await dialog.DismissAsync();
                await page.WaitForTimeoutAsync(6000);
            };


            await page.ClickAsync("//button[text()='Show Confirm']");
            await page.WaitForTimeoutAsync(6000);

        }
    }
}