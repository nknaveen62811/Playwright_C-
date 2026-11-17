using Microsoft.Playwright;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playwright_Demo2
{
    public class Cent
    {
        [Test]
        public async Task nk()
        {
            using var a = await Playwright.CreateAsync();
            var b = await a.Chromium.LaunchAsync(new BrowserTypeLaunchOptions { Headless = false });
            var context = await b.NewContextAsync();
            var page = await context.NewPageAsync();
            await page.GotoAsync("https://www.flipkart.com/");
            await page.WaitForTimeoutAsync(1000);
            await page.HoverAsync("//div[@class=\"pStjB2 lr29Nk\"]");
            await page.WaitForTimeoutAsync(1000);
            await page.ClickAsync("//div[@class=\"pStjB2 lr29Nk\"]");
            await page.WaitForTimeoutAsync(1000);
            await page.FillAsync("//div[@class=\"XizdcU Zl53fz\"]/input[@type=\"text\"]", "6303704529");
            await page.WaitForTimeoutAsync(1000);
            await page.ClickAsync("//div[@class=\"q2U9_I\"]/button[text()='Request OTP']");
            await page.WaitForTimeoutAsync(20000);
           
            
            await page.FillAsync("//input[@name=\"q\"]", "FRENCH ESSENCE Luxury Aura Scent With Long Lasting Fragrance For Ladies Eau de Parfum - 60 ml (For Women)");
            await page.PressAsync("//input[@name=\"q\"]", "Enter");
            await page.WaitForTimeoutAsync(2000);
            await page.ClickAsync("//div[@data-id=\"PERGSZCDGDFTWHCU\"]/div/a[2]");
            await page.WaitForTimeoutAsync(2000);

            var pag = context.Pages;
            var childpage = pag[1];
            await childpage.ClickAsync("//li[@class=\"col col-6-12 \"]/button[@class=\"dSM5Ub ugg2XR IUmgrZ\"]");
            await childpage.WaitForTimeoutAsync(2000);
            await childpage.ClickAsync("//button[@type=\"button\"]");
            await childpage.WaitForTimeoutAsync(2000);
            await childpage.ClickAsync("//button[@class=\"dSM5Ub gRSEA4 KcXDCU\"]");
            await childpage.WaitForTimeoutAsync(2000);
            await childpage.ClickAsync("//span[text()='Place Order']");
            await childpage.WaitForTimeoutAsync(20000);
            
            
           


        }
    }
}