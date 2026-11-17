using Microsoft.Playwright;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Playwright_Demo2
{
    [TestFixture]
    public class Class3
    {



       IPlaywright playwright;
        IBrowser browser;
        IBrowserContext context;
        IPage page;
        

        [OneTimeSetUp]
        public async Task LaunchBrowser()
        {
            playwright = await Playwright.CreateAsync();
            browser = await playwright.Chromium.LaunchAsync(
                new BrowserTypeLaunchOptions
                {
                    Headless = false
                });
        }

        [SetUp]
        public async Task CreatePage()
        {
            context = await browser.NewContextAsync();
            page = await context.NewPageAsync();

        }

        [Test]
        public async Task OpenGoogleTest()
        {
            await page.GotoAsync("https://www.google.com");
            await page.WaitForTimeoutAsync(4000);
        }
        [Test]
        public async Task nk()
        {
            await page.GotoAsync("https://www.flipkart.com/");
            await page.WaitForTimeoutAsync(4000);
        }

        [TearDown]
        public async Task ClosePage()
        {
            await context.CloseAsync();
        }

        [OneTimeTearDown]
        public async Task CloseBrowser()
        {
            await browser.CloseAsync();
            playwright.Dispose();
        }
    }
}
