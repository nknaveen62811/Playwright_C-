using Microsoft.Playwright;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playwright_Demo2
{
    public class HyrTask
    {


        [Test]
        public async Task nk()
        {
            using var a = await Playwright.CreateAsync();
            var b = await a.Chromium.LaunchAsync(new BrowserTypeLaunchOptions { Headless = false });
            var context = await b.NewContextAsync();
            var page = await context.NewPageAsync();

            await page.GotoAsync("https://www.hyrtutorials.com/");
            await page.WaitForTimeoutAsync(2000);
            await page.HoverAsync("//a[text()='Selenium Practice']");
            await page.HoverAsync("//a[text()='Window Handles']");
            await page.ClickAsync("//a[text()='Window Handles']");
            await page.WaitForTimeoutAsync(4000);
             await page.ClickAsync("//button[@id=\"newTabBtn\"]");
              await page.WaitForTimeoutAsync(2000);

              var pag = context.Pages;


                  pag[1].Dialog += async (_, dilog) =>
                   {
                       Console.WriteLine("ERROR:THIS IS ELON MUSK" +dilog.Message);
                       dilog.AcceptAsync();
                   };
                  var title = await pag[1].TitleAsync();
                   Console.WriteLine(title);



                   await pag[0].WaitForTimeoutAsync(7000);
                   var title1 = await pag[0].TitleAsync();
                   Console.WriteLine(title1);

                   if(title1!=title)
                   {
                       await pag[1].ReloadAsync();

                   }
                   else
                   {
                       Console.WriteLine("NOT MOVED TON PARENT WINDOW");
                   }
              

           
        }
    }
}