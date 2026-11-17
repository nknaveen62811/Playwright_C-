using Microsoft.Playwright;
using NUnit.Framework;
using System.Threading.Tasks;

[TestFixture]
public class MathTests
{
    IPlaywright playwright;
    IBrowser browser;
    IPage page;

    [SetUp]
    public async Task Setup()
    {
        playwright = await Playwright.CreateAsync();
        browser = await playwright.Chromium.LaunchAsync(new BrowserTypeLaunchOptions
        {
            Headless = false
        });

        page = await browser.NewPageAsync();

        // Launch Google before every test
        await page.GotoAsync("https://www.google.com");
    }

    [Test ,Order(2)]
    public async Task AdditionTest()
    {
        // First test → Flipkart
        await page.GotoAsync("https://www.flipkart.com");
        await page.WaitForTimeoutAsync(3000);
    }

    [Test ,Order(1)]
    public async Task SubtractionTest()
    {
        // Second test → Amazon
        await page.GotoAsync("https://www.amazon.in");
        await page.WaitForTimeoutAsync(3000);
    }

    [Test, Order(3)]
    [Ignore("Feature not ready")]
    public async Task MultiplicationTest()
    {
        // Third test → stay on Google or do anything
        string title = await page.TitleAsync();
        TestContext.WriteLine("Page title is: " + title);
    }

    [TearDown]
    public async Task TearDown()
    {
        await browser.CloseAsync();
        playwright.Dispose();
    }
}
