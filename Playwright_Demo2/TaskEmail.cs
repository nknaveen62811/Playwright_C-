using Microsoft.Playwright;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Playwright_Demo2
{
    public class TaskEmail
    {


        [Test]
        public async Task nk()
        {
            using var a = await Playwright.CreateAsync();
            var b = await a.Chromium.LaunchAsync(new BrowserTypeLaunchOptions { Headless = false });
            var context = await b.NewContextAsync();
            var page = await context.NewPageAsync();
            //    await page.GotoAsync("https://accounts.google.com/v3/signin/identifier?authuser=0&continue=https%3A%2F%2Fmail.google.com%2Fmail&ec=GAlAFw&hl=en&service=mail&flowName=GlifWebSignIn&flowEntry=AddSession&dsh=S-1609648235%3A1764339029756461");
            //  await page.GotoAsync("https://testautomationpractice.blogspot.com/");
            //  await page.WaitForTimeoutAsync(2000);

            //    var val = page.Locator("//div[@class=\"VfPpkd-aPP78e\"]/following::div[1]/ul/li");
            //    var val1 = await val.AllInnerTextsAsync();
            await page.GotoAsync("https://www.hyrtutorials.com/p/add-padding-to-containers.html");

            var val1 = await page.Locator("//select[@id=\"BlogArchive1_ArchiveMenu\"]/option").AllInnerTextsAsync();
            await page.WaitForTimeoutAsync(2000);
            foreach (var ite in val1)
            {
                Console.WriteLine(ite);
            }
            Console.WriteLine(val1);


            await page.WaitForTimeoutAsync(4000);
         


        }


    }
}
