using Microsoft.Playwright;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Playwright_Demo2
{
    public class Youtube
    {

        [Test]
        public async Task nk()
        {
            using var a = await Playwright.CreateAsync();
            var b = await a.Chromium.LaunchAsync(new BrowserTypeLaunchOptions { Headless = false });
            var context = await b.NewContextAsync();
            var page = await context.NewPageAsync();

            var BaseUrl = "file:///C:/Users/NK%20NAVEEN/OneDrive/Desktop/Login.html";


            await page.GotoAsync(BaseUrl);

            await page.WaitForTimeoutAsync(2000);

            await page.FillAsync("//input[@id=\"email\"]", "durga@gmail.com");

            await page.WaitForTimeoutAsync(2000);

            await page.FillAsync("//input[@id=\"password\"]", "durga@123");

            await page.WaitForTimeoutAsync(2000);

            await page.ClickAsync("//button[normalize-space()='Sign In']");


            await page.WaitForTimeoutAsync(6000);


        }
    }
}
