using Microsoft.Playwright;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playwright_Demo2
{
    public class Checkbox
    {
        
        
            [Test]
            public async Task nk()
            {
                using var play = await Playwright.CreateAsync();
                var Browser = await play.Chromium.LaunchAsync(new BrowserTypeLaunchOptions { Headless = false });


                var context = await Browser.NewContextAsync();
                var page = await context.NewPageAsync();
                await page.GotoAsync("https://rahulshettyacademy.com/AutomationPractice/");
                await page.WaitForTimeoutAsync(4000);
            /*
            await page.Locator("//input[@id='checkBoxOption1']").CheckAsync();
            await page.WaitForTimeoutAsync(4000);
            await page.CheckAsync("//input[@id='checkBoxOption2']");
            await page.WaitForTimeoutAsync(4000);
            await page.CheckAsync("//input[@id='checkBoxOption3']");
            await page.WaitForTimeoutAsync(7000);
            await page.UncheckAsync("//input[@id='checkBoxOption1']");
            await page.WaitForTimeoutAsync(7000);
            */






            await page.CheckAsync("(//input[@name=\"radioButton\"])[2]");
            await page.WaitForTimeoutAsync(4000);
            await page.CheckAsync("(//input[@name=\"radioButton\"])[1]");

    await page.WaitForTimeoutAsync(4000);
            await page.CheckAsync("(//input[@name=\"radioButton\"])[3]");
            await page.WaitForTimeoutAsync(4000);
            
        }
        }

    }
    