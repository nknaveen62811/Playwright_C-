using Microsoft.Playwright;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playwright_Demo2
{
    public class foreachcs
    {


        [Test]
        public async Task nk()
        {
            
                using var play = await Playwright.CreateAsync();
                var Browser = await play.Chromium.LaunchAsync(new BrowserTypeLaunchOptions { Headless = false });


                var context = await Browser.NewContextAsync();
                var page = await context.NewPageAsync();

                HashSet<string> Url = new HashSet<string>()
        {
     "https://www.flipkart.com/","https://www.youtube.com/","https://www.hyrtutorials.com/","https://www.flipkart.com/"

     };
            foreach(var url in Url)
            {
                page.GotoAsync(url);
                await page.WaitForTimeoutAsync(2000);
                var title = await page.TitleAsync();
                Console.WriteLine(title);
                if(title.Contains("YouTube"))
                {
                    break;
                }
            }
        }
        }
    }
