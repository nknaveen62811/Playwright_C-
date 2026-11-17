using Microsoft.Playwright;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playwright_Demo2
{
    internal class Mouse
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



              await page.Locator("//button[text()='Copy Text']").ScrollIntoViewIfNeededAsync();
             await page.WaitForTimeoutAsync(2000);


            //Double Click 
              await page.DblClickAsync("//button[text()='Copy Text']");
             await page.WaitForTimeoutAsync(7000);

            //Drag and Dropp Click
             await page.DragAndDropAsync("//div[@id='draggable']", "//div[@id='droppable']");
             await page.WaitForTimeoutAsync(7000);

            //Hover
              await page.HoverAsync("//button[@class='dropbtn']");
             await page.WaitForTimeoutAsync(2000);
             await page.HoverAsync("//a[text()='Laptops']");
             await page.WaitForTimeoutAsync(7000);
            await page.ClickAsync("//input[@id='field2']", new() { Button=MouseButton.Middle });

            await page.SelectOptionAsync("//select[@id='country']", new SelectOptionValue { Label = "Japan" });


/*
            await page.ClickAsync("//input[@id='name']");
            await page.WaitForTimeoutAsync(2000);
            await page.TypeAsync("//input[@id='name']", "For Selenium");
            string aaaa = await page.InputValueAsync("//input[@id='name']");
            for(int i=0;i<=5;i++)
            {
                await page.GotoAsync("https://youtu.be/k3p8CIZWFww?si=47nwARdKjJbDO6bl");
            }
*/
            await page.WaitForTimeoutAsync(7000);

        }
    }
}

