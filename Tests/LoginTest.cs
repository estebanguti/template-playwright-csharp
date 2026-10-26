using Microsoft.Playwright.NUnit;
using Microsoft.Playwright;
using template_playwright_csharp.Pages;

namespace template_playwright_csharp.Tests;

public class Tests : PageTest 
{

    [Test]
    public async Task LoginSuccessfull()
    {
        var LoginPage = new LoginPage(Page);
        await LoginPage.GotoAsync();
        await LoginPage.Login("standard_user","secret_sauce");

        var homePage = new HomePage(Page);

        await Expect(homePage.ShoppingCart).ToBeVisibleAsync();
    }
    
}
