using Microsoft.Playwright;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playwright_Demo2
{
    public class File
    {
        [Test]
        public async Task nk()
        {
            using var a = await Playwright.CreateAsync();
            var b = await a.Chromium.LaunchAsync(new BrowserTypeLaunchOptions { Headless = false });
            var context = await b.NewContextAsync();
            var page = await context.NewPageAsync();
            await page.GotoAsync("https://testautomationpractice.blogspot.com/");
            await page.WaitForTimeoutAsync(2000);

            //   await page.Locator("//input[@id=\"singleFileInput\"]").ScrollIntoViewIfNeededAsync();
            // await page.WaitForTimeoutAsync(4000);

            /*  await page.Locator("//input[@id=\"singleFileInput\"]").SetInputFilesAsync("C:\\Users\\NK NAVEEN\\OneDrive\\Pictures\\Screenshots\\Bhaddhe1");
             await page.SetInputFilesAsync("//input[@id=\"singleFileInput\"]", "C:\\Users\\NK NAVEEN\\OneDrive\\Pictures\\Screenshots\\Bhaddhe1");
             await page.WaitForTimeoutAsync(4000);
             await page.ClickAsync("//button[text()='Upload Single File']");
             await page.WaitForTimeoutAsync(4000);
             var text = await page.Locator("//p[@id=\"singleFileStatus\"]").TextContentAsync();
             Console.WriteLine(text);
             await page.WaitForTimeoutAsync(2000);
            
            
            await page.SetInputFilesAsync("//input[@id=\"singleFileInput\"]", "C:\\Users\\NK NAVEEN\\OneDrive\\Pictures\\Screenshots\\Bhaddhe1");


            await page.WaitForTimeoutAsync(4000);

            await page.ClickAsync("//button[text()='Upload Single File']");
            await page.WaitForTimeoutAsync(4000);
            var bb = await page.Locator("//p[@id=\"singleFileStatus\"]").InnerTextAsync();
            Console.WriteLine(bb);
           
            await page.SetInputFilesAsync("//input[@id=\"multipleFilesInput\"]", new[] {
                "C:\\Users\\NK NAVEEN\\OneDrive\\Pictures\\Screenshots\\Bhaddhe1",
                "C:\\Users\\NK NAVEEN\\OneDrive\\Pictures\\Screenshots\\Bhaddhe2- Copy" }
            
            );
            await page.WaitForTimeoutAsync(4000);
            await page.ClickAsync("//button[text()='Upload Multiple Files']");
            var dd = await page.Locator("//p[@id=\"multipleFilesStatus\"]").InnerTextAsync();
            Console.WriteLine( dd );
            */
        }
      //  await page.WaitForTimeoutAsync(4000);
        }
            
       
    }
