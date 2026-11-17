using NUnit.Framework;
using System.Threading.Tasks;

public class UsingChromeData : PageSetup
{
    [SetUp]
    public async Task Setup()
    {
        await InitializeAsync();   // inherited method
    }
    [Test]
    public async Task nk()
    {
        await Page.GotoAsync("https://testautomationpractice.blogspot.com/");
        await Page.WaitForTimeoutAsync(2000);
        var aa = await Page.Locator("//table[@name=\"BookTable\"]//tbody//td[position()=3]").AllInnerTextsAsync();
        foreach (var text in aa)
        {

            Console.WriteLine(text);

        }
        await Page.WaitForTimeoutAsync(4000);

    }
}