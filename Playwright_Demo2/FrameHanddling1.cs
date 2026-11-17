using Microsoft.Playwright;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playwright_Demo2
{


    public class FrameHanddling1
{

    [Test]
    public async Task nk()
    {
        using var a = await Playwright.CreateAsync();
        var b = await a.Chromium.LaunchAsync(new BrowserTypeLaunchOptions { Headless = false });
        var context = await b.NewContextAsync();
        var page = await context.NewPageAsync();
            await page.GotoAsync("https://www.w3schools.com/tags/tryit.asp?filename=tryhtml_big_css");
            await page.WaitForTimeoutAsync(2000);

           
            var frame = page.FrameLocator("//iframe[@id=\"iframeResult\"]");
        var bbb=    await frame.Locator("//p[text()='This is a much bigger paragraph.']").InnerTextAsync();
            Console.WriteLine(bbb);
            await page.WaitForTimeoutAsync(7000);
        }
}
}