using Microsoft.Playwright;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playwright_Demo2
{
    public class Frame
    {
        [Test]
        public async Task nk()
        {
            using var play = await Playwright.CreateAsync();
            var browser = await play.Chromium.LaunchAsync(new BrowserTypeLaunchOptions { Headless = false });
            var context = await browser.NewContextAsync();
            var page = await context.NewPageAsync();
         //   await page.GotoAsync("https://www.w3schools.com/jsref/tryit.asp?filename=tryjsref_onclick");
          //  await page.WaitForTimeoutAsync(2000);
            /*
                        //FrameLocator
                        var frame = page.FrameLocator("//iframe[@id=\"iframeResult\"]");
                        await frame.Locator("//button[text()='Click me']").ClickAsync();
            */


            //Indexing
            /*
        var frame = page.Frames[1];
        await frame.Locator("//button[text()='Click me']").ClickAsync();


        */

            await page.GotoAsync("https://www.w3schools.com/tags/tryit.asp?filename=tryhtml_abbr_test");
            //   var frame = page.FrameLocator("//iframe[@id=\"iframeResult\"]");
            var frame = page.Frames[1];
            await frame.Locator("//abbr[text()='WHO']").DblClickAsync();
            await page.WaitForTimeoutAsync(7000);

        }
    }
}
