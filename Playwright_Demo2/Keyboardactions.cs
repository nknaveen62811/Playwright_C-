using Microsoft.Playwright;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playwright_Demo2
{
    public class Keyboardactions
    {

        [Test]
        public async Task nk()
        {
            using var a = await Playwright.CreateAsync();
            var b = await a.Chromium.LaunchAsync(new BrowserTypeLaunchOptions { Headless = false });
            var context = await b.NewContextAsync();
            var page = await context.NewPageAsync();
            await page.GotoAsync("https://www.hyrtutorials.com/p/basic-controls.html");
            await page.WaitForTimeoutAsync(2000);

            await page.DblClickAsync("//h1[text()='Basic Controls in HTML']");
            await page.WaitForTimeoutAsync(2000);

            
                        await page.Keyboard.DownAsync("Shift");
                        for(int va=1;va<=10;va++)
                        {
                            await page.Keyboard.PressAsync("ArrowDown");
                            await page.WaitForTimeoutAsync(2000);
                        }
                        await page.Keyboard.UpAsync("Shift");


                       for(var va1=1;va1<=10;va1++)
                        {
                            await page.Keyboard.PressAsync("ArrowDown");
                            await page.WaitForTimeoutAsync(2000);
                        }
            /*
            await page.Keyboard.PressAsync("PageDown");
            */
            await page.WaitForTimeoutAsync(7000);
        }
    }
}