using Microsoft.Playwright;
using NUnit.Framework;
using System.Threading.Tasks;

[TestFixture]
public class GoogleTests
{
    IPlaywright playwright;
    IBrowser browser;
    IPage page;

    // Runs ONCE before all tests
    [OneTimeSetUp]
    public async Task OneTimeSetup()
    {
        playwright = await Playwright.CreateAsync();
        browser = await playwright.Chromium.LaunchAsync(new BrowserTypeLaunchOptions
        {
            Headless = false
        });
    }

    // Runs BEFORE EACH test
    [SetUp]
    public async Task Setup()
    {
        page = await browser.NewPageAsync();
    }

    // ----------- TEST 1 -----------
    [Test]
    [Category("Smoke")]
    public async Task OpenGoogle()
    {
        await page.GotoAsync("https://www.google.com");
        string title = await page.TitleAsync();
        Assert.AreEqual("Google", title);
    }

    // ----------- TEST 2 -----------
    [Test]
    [Category("Regression")]
    public async Task GoogleSearchBoxIsVisible()
    {
        await page.GotoAsync("https://www.google.com");
        bool isVisible = await page.Locator("textarea[name='q']").IsVisibleAsync();
        Assert.IsTrue(isVisible);
    }

    // ----------- TEST 3 (Data-driven) -----------
    [TestCase("Playwright")]
    [TestCase("NUnit")]
    public async Task GoogleSearch_WithMultipleData(string searchText)
    {
        await page.GotoAsync("https://www.google.com");
        await page.FillAsync("textarea[name='q']", searchText);
        await page.Keyboard.PressAsync("Enter");

        Assert.IsTrue(await page.TitleAsync() != null);
    }

    // Runs AFTER EACH test
    [TearDown]
    public async Task TearDown()
    {
        await page.CloseAsync();
    }

    // Runs ONCE after all tests
    [OneTimeTearDown]
    public async Task OneTimeTearDown()
    {
        await browser.CloseAsync();
        playwright.Dispose();
    }
}
