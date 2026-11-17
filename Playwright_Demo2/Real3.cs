using Microsoft.Playwright;
using NUnit.Framework;
using System.Threading.Tasks;

[TestFixture]
public class LoginTests
{
    IPlaywright playwright;
    IBrowser browser;
    IPage page;

    [OneTimeSetUp]
    public async Task OneTimeSetup()
    {
        playwright = await Playwright.CreateAsync();
        browser = await playwright.Chromium.LaunchAsync(new BrowserTypeLaunchOptions
        {
            Headless = false
        });
    }

    [SetUp]
    public async Task Setup()
    {
        page = await browser.NewPageAsync();
    }

    [Test]
    [Retry(3)]
    public async Task LoginButtonAppears()
    {
        await page.GotoAsync("https://example.com");
        await page.WaitForTimeoutAsync(2000);

        bool isVisible = await page.IsVisibleAsync("n"); // example selector
        Assert.IsTrue(isVisible, "Login button not visible");
    }

    [TearDown]
    public async Task TearDown()
    {
        await page.CloseAsync();
    }

    [OneTimeTearDown]
    public async Task OneTimeTearDown()
    {
        await browser.CloseAsync();
        playwright.Dispose();
    }
}
