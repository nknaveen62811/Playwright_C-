using Microsoft.Playwright;
using System;
using System.Collections.Generic;
using System.Formats.Asn1;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playwright_Demo2
{
    public class DragandDrop
    {

        [Test]
        public async Task nk()
        {
            using var a = await Playwright.CreateAsync();
            var b = await a.Chromium.LaunchAsync(new BrowserTypeLaunchOptions { Headless = false });
            var context = await b.NewContextAsync();
            var page = await context.NewPageAsync();
            await page.GotoAsync("https://www.myntra.com/?utm_source=dms_google&utm_medium=dms_searchbrand_cpc&utm_campaign=dms_google_searchbrand_cpc_Search_Brand_Myntra_Brand_India_BM_TROAS_SOK_New&gad_source=1&gad_campaignid=20443628324&gbraid=0AAAAADoxBh6sS4vO_LaXyABaI2tUH2ocy&gclid=Cj0KCQjwyr3OBhD0ARIsALlo-Ok8r13Yv6uMMtkPsLSxH3Ih59KpjlKkR36NikN6WE7SwGVh3_YtbfIaAlcaEALw_wcB");
            await page.WaitForTimeoutAsync(4000);
            await page.HoverAsync("//a[text()='Kids' and @href=\"/shop/kids\" and @class=\"desktop-main\"]");
            await page.WaitForTimeoutAsync(2000);
            await page.ClickAsync("//a[text()='Flipflops']");
            await page.WaitForTimeoutAsync(4000);
            
            for (int i = 0; i < 10; i++)
            {
                await page.Keyboard.PressAsync("ArrowDown");

                await page.WaitForTimeoutAsync(2000);     
          }
            await page.Keyboard.PressAsync("PageUp");
            await page.WaitForTimeoutAsync(2000);
            await page.ClickAsync("//img[@title=\"max Boys Clogs\"]");
            await page.WaitForTimeoutAsync(4000);

            var Parent =  context.Pages;
            var child =  Parent[1];

            await child.ClickAsync("//button[@fdprocessedid=\"4dbtqd\"]");
            await page.WaitForTimeoutAsync(4000);


        }
       
     

     
    }
   
}