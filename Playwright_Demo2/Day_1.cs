using Microsoft.Playwright;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playwright_Demo2
{


    public class Day_1
    {

        [Test]
        public async Task nk()
        {

             using var a = await Playwright.CreateAsync();

             var b = await a.Chromium.LaunchAsync(new BrowserTypeLaunchOptions { Headless = false });

             var context = await b.NewContextAsync();

             var page = await context.NewPageAsync();

             var Url = "https://testautomationpractice.blogspot.com/";

              await page.GotoAsync(Url);


            //Handling Text Fields
            //Navigation Commands
            // Mouse Actions 
            // getting data from the web page
            //handling checkboxes
            //Handle RadioButtons
            //Scrolling Methods


            await page.WaitForTimeoutAsync(4000);



            

           










        }
    }
}
