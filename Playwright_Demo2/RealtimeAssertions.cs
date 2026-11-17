using Microsoft.Playwright;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playwright_Demo2
{
    public class RealtimeAssertions
    {

        [Test]
        public async Task nk()
        {
            using var a = await Playwright.CreateAsync();
            var b = await a.Chromium.LaunchAsync(new BrowserTypeLaunchOptions { Headless = false });
            var context = await b.NewContextAsync();
            var page = await context.NewPageAsync();
            await page.GotoAsync("https://opensource-demo.orangehrmlive.com/web/index.php/auth/login");
            await page.WaitForTimeoutAsync(2000);


            //   await page.FillAsync("//input[@name=\"username\"]", "Admin");

            /*
             
             // Assert.IsTrue(await page.Locator("//h5[text()='Login']").IsVisibleAsync(), "NOt Visible");
            // string aa = await page.Locator("//h5[text()='Login']").InnerTextAsync();

            //  Assert.AreEqual(aa.Trim(), "Login","Both aRE not Maching");
            string aa = "https://opensource-demo.orangehrmlive.com/web/index.php/auth/login";


            // Assert.AreEqual(aa, "https://opensource-demo.orangehrmlive.com/web/index.php/auth/login");

            //  Assert.IsTrue(page.Url.Contains(aa));
            string value =
    await page.Locator("//input[@name='username']").InputValueAsync();

            Assert.AreEqual(value,"Admin");

             

            // ================= ACTIONS =================
            await page.FillAsync("//input[@name='username']", "Admin");
            await page.FillAsync("//input[@name='password']", "admin123");
            await page.ClickAsync("//button[@type='submit']");

            // ================= VALIDATIONS =================
            Assert.Multiple(async () =>
            {
                // 1️⃣ Page title validation
                Assert.That(
                    await page.TitleAsync(),
                    Is.EqualTo("OrangeHRM"),
                    "Page title is incorrect"
                );

                // 2️⃣ URL validation
                Assert.That(
                    page.Url,
                    Does.Contain("/dashboard"),
                    "Dashboard URL not loaded"
                );

                // 3️⃣ Element visibility
                Assert.True(
                    await page.Locator("//h6[text()='Dashboard']").IsVisibleAsync(),
                    "Dashboard heading not visible"
                );

                // 4️⃣ User profile visibility
                Assert.True(
                    await page.Locator("//span[@class='oxd-userdropdown-tab']").IsVisibleAsync(),
                    "User profile not visible"
                );

                // 5️⃣ Button enabled state
                Assert.True(
                    await page.Locator("//button[@type='submit']").IsEnabledAsync(),
                    "Login button disabled"
                );

                // 6️⃣ Element existence
                Assert.True(
                    await page.Locator("//input[@name='username']").CountAsync() > 0,
                    "Username field missing"
                );

                // 7️⃣ Text validation
                Assert.That(
                    await page.Locator("//h6[text()='Dashboard']").TextContentAsync(),
                    Is.EqualTo("Dashboard"),
                    "Dashboard text mismatch"
                );

                // 8️⃣ Attribute validation
                Assert.That(
                    await page.Locator("//input[@name='username']").GetAttributeAsync("placeholder"),
                    Is.EqualTo("Username"),
                    "Username placeholder incorrect"
                );

                // 9️⃣ Value validation
                Assert.That(
                    await page.Locator("//input[@name='username']").InputValueAsync(),
                    Is.EqualTo("Admin"),
                    "Username value mismatch"
                );

                // 🔟 Multiple element count (table/list)
                Assert.True(
                    await page.Locator("//ul/li").CountAsync() > 0,
                    "Menu items not loaded"
                );
            });


            Assert.That(await page.Locator("//p[text()='Time at Work']").InnerTextAsync(), Is
                .EqualTo("Time at Work"));
            */
            await page.FillAsync("//input[@name='username']", "Admin");
            await page.FillAsync("//input[@name='password']", "admin123");
            await page.ClickAsync("//button[@type='submit']");

            Assert.That(await page.Locator("//h6[text()='Dashboard']").InnerTextAsync(), Is.EqualTo("Dashboard"));
            await page.WaitForTimeoutAsync(2000);
            await page.ClickAsync("//span[text()='PIM']");
            await page.WaitForTimeoutAsync(2000);
            await page.ClickAsync("//span[normalize-space()='Configuration']");
            var gg = await page.Locator("//ul[@role=\"menu\"]/li").AllInnerTextsAsync();
            foreach (var text in gg)
            {
                Console.WriteLine(text);
            }
               
           
            await page.WaitForTimeoutAsync(8000);

         //   Assert.AreEqual("asd", "dfg", "Error messsaage");

            Assert.That(await page.Locator("//ul[@role=\"menu\"]/li[2]").InnerTextAsync(), Is.EqualTo("Custom Fields"),"Not maching");
            Console.WriteLine("Value is mached to the Xpath");



        }
    }

}