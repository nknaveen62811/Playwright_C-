using Microsoft.Playwright;
using NUnit.Framework;

namespace RealTimePlaywrightTests
{
    [TestFixture]
    public class EmployeeSearchTest
    {
        private IPlaywright playwright;
        private IBrowser browser;
        private IPage page;

        [OneTimeSetUp]
        public async Task BrowserSetup()
        {
            playwright = await Playwright.CreateAsync();
            browser = await playwright.Chromium.LaunchAsync(new BrowserTypeLaunchOptions
            {
                Headless = false
            });
        }

        [SetUp]
        public async Task TestSetup()
        {
            page = await browser.NewPageAsync();
        }

        [Test]
        public async Task A()
        {

            await page.GotoAsync("https://opensource-demo.orangehrmlive.com/web/index.php/auth/login");
            await page.WaitForTimeoutAsync(2000);

            await page.FillAsync("//input[contains(@name,\"username\")]", "admin");
            await page.FillAsync("//input[contains(@name,\"password\")]","admin123");
            await page.WaitForTimeoutAsync(2000);
            await page.ClickAsync("//button[contains(@type,\"submit\")]");
            await page.WaitForTimeoutAsync(4000);


            await page.Locator("//h6[text()='Dashboard']").IsVisibleAsync();
            var tit = await page.TitleAsync();
            Assert.AreEqual("OrangeHRM", tit);
            Console.WriteLine("Mathted");

            await page.WaitForTimeoutAsync(2000);
            await page.ClickAsync("//span[text()='PIM']");
            await page.WaitForSelectorAsync("//h6[text()='PIM']");
            await page.WaitForTimeoutAsync(4000);
            await page.FillAsync("//input[@placeholder='Type for hints...']", "Bhaddhe");
            await page.ClickAsync("//button[@type='submit']");

            // 6️⃣ Validate search result
            await page.WaitForSelectorAsync("//div[@class='oxd-table-body']");

         var val=   await page.Locator("//input[@placeholder='Type for hints...']").InputValueAsync();
            string b = "Bhaddhe";
            if(val.Equals(b))
            {
                await page.ClickAsync("//button[@type=\"button\" and @title=\"Help\"]");
                await page.WaitForTimeoutAsync(4000);
            }

            
        }
            
        

        [TearDown]
        public async Task ClosePage()
        {
            await page.CloseAsync();
        }

        [OneTimeTearDown]
        public async Task CloseBrowser()
        {
            await browser.CloseAsync();
            playwright.Dispose();
        }
    }
}
