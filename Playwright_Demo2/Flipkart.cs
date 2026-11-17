using Microsoft.Playwright;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playwright_Demo2
{
    public class Flipkart
    {
        [Test]
        public async Task nk()
        {
            using var a = await Playwright.CreateAsync();
            var b = await a.Chromium.LaunchAsync(new BrowserTypeLaunchOptions { Headless = false });
            var context = await b.NewContextAsync();
            var page = await context.NewPageAsync();
            await page.GotoAsync("https://www.myntra.com/?utm_source=dms_google&utm_medium=dms_searchbrand_cpc&utm_campaign=dms_google_searchbrand_cpc_Search_Brand_Myntra_Brand_India_BM_TROAS_SOK_New&gad_source=1&gad_campaignid=20443628324&gbraid=0AAAAADoxBh6z4XYN_Jij_Q4XekWFez5xH&gclid=Cj0KCQiAosrJBhD0ARIsAHebCNpvRJvaozLLL7aOSNfL3ifdD1VFeofsNJU6j-YUPSkRInB1GMQCqssaAjswEALw_wcB");
            await page.WaitForTimeoutAsync(2000);
            await page.HoverAsync("(//a[@class=\"desktop-main\"])[3]");
            await page.WaitForTimeoutAsync(2000);


            var Girl = await page.Locator("//li[@data-reactid=\"370\"]/ul/li").AllInnerTextsAsync();
              
              foreach(var text in Girl)
            {
                Console.WriteLine(text);
                
            }
            var url = page.Url;

            Console.WriteLine(url);
            
                        if (url.Equals("https://www.myntra.com/?utm_source=dms_google&utm_medium=dms_searchbrand_cpc&utm_campaign=dms_google_searchbrand_cpc_Search_Brand_Myntra_Brand_India_BM_TROAS_SOK_New&gad_source=1&gad_campaignid=20443628324&gbraid=0AAAAADoxBh6z4XYN_Jij_Q4XekWFez5xH&gclid=Cj0KCQiAosrJBhD0ARIsAHebCNpvRJvaozLLL7aOSNfL3ifdD1VFeofsNJU6j-YUPSkRInB1GMQCqssaAjswEALw_wcB"))
                        {
                            await page.ClickAsync("(//li[@data-reactid=\"370\"]/ul/li)[10]");
                            await page.WaitForTimeoutAsync(4000);


                        }
                        await page.WaitForTimeoutAsync(2000);



                            await page.ClickAsync("//ul[@class=\"results-base\"]/li[1]");
                            await page.WaitForTimeoutAsync(4000);




                        await page.WaitForTimeoutAsync(4000);
                        var pag = context.Pages;
                        var childpage = pag[1];

                        await childpage.ClickAsync("(//button[@class=\"size-buttons-size-button size-buttons-size-button-default size-buttons-big-size\"])[2]");
                        await childpage.WaitForTimeoutAsync(2000);
                        await childpage.ClickAsync("//*[@id=\"mountRoot\"]/div/div[1]/main/div[2]/div[2]/div[2]/div[2]/div/div[1]");

                        
               await childpage.WaitForTimeoutAsync(4000);




        }
    }
}