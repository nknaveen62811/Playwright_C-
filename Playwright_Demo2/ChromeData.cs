using Microsoft.Playwright;
using System.Threading.Tasks;

public class PageSetup
{
    protected IPlaywright Playwright;
    protected IBrowser Browser;
    protected IBrowserContext Context;
    protected IPage Page;

    public async Task InitializeAsync()
    {
        Playwright = await Microsoft.Playwright.Playwright.CreateAsync();

        Browser = await Playwright.Chromium.LaunchAsync(
            new BrowserTypeLaunchOptions
            {
                Headless = false
            });

        Context = await Browser.NewContextAsync();
        Page = await Context.NewPageAsync();
    }

    public async Task CloseAsync()
    {
        await Context.CloseAsync();
        await Browser.CloseAsync();
        Playwright.Dispose();
    }
}
