using Microsoft.Playwright;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playwright_Demo2
{
    public class Alerts2
    {
        [Test]
        public async Task nk()
        {
            using var a = await Playwright.CreateAsync();
            var b = await a.Chromium.LaunchAsync(new BrowserTypeLaunchOptions { Headless = false });
            var context = await b.NewContextAsync();
            var page = await context.NewPageAsync();
            await page.GotoAsync("https://vinothqaacademy.com/alert-and-popup/");
            await page.WaitForTimeoutAsync(2000);
            page.Dialog += async (_, nk) =>
            {
                Console.WriteLine("The Error Messeage is :" + nk.Message);
                nk.AcceptAsync("POOOOOORAAAAAAAAAA");
            };
            await page.ClickAsync("//button[@name='promptalertbox1234']");
            await page.WaitForTimeoutAsync(6000);
        }
    }
}