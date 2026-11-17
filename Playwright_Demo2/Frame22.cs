using Microsoft.Playwright;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playwright_Demo2
{
    public class Frame22
    {

        [Test]
        public async Task nk()
        {
            using var a = await Playwright.CreateAsync();
            var b = await a.Chromium.LaunchAsync(new BrowserTypeLaunchOptions { Headless = false });
            var context = await b.NewContextAsync();
            var page = await context.NewPageAsync();
            await page.GotoAsync("https://www.w3schools.com/html/tryit.asp?filename=tryhtml_paragraphs1");
            await page.WaitForTimeoutAsync(2000);


            var iframe = page.Frames;
            var childframe = iframe[1];
            await childframe.WaitForTimeoutAsync(7000);
            await childframe.Locator("(//p[text()='This is a paragraph.'])[3]").DblClickAsync();
           

            var ele = await childframe.Locator("(//p[text()='This is a paragraph.'])[3]").InnerTextAsync();
            Console.WriteLine(ele);
            await childframe.WaitForTimeoutAsync(7000);
        }
    }
}