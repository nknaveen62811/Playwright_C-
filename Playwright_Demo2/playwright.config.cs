using Microsoft.Playwright;

public class PlaywrightConfig
{
    public static BrowserTypeLaunchOptions BrowserOptions = new()
    {
        Headless = false
    };
}