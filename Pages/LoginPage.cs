using Microsoft.Playwright;

namespace template_playwright_csharp.Pages;

public class LoginPage
{
    private readonly IPage _page;
    private readonly ILocator _userInput;
    private readonly ILocator _passwordInput;
    private readonly ILocator _loginButton;

    public LoginPage(IPage page)
    {
        _page = page;
        _userInput = _page.Locator("#user-name");
        _passwordInput = _page.Locator("#password");
        _loginButton = _page.Locator("#login-button");
    }

    public async Task GotoAsync()
    {
        await _page.GotoAsync("https://www.saucedemo.com/v1/index.html");
    }

    public async Task Login(string username, string password)
    {
        await _userInput.FillAsync(username);
        await _passwordInput.FillAsync(password);
        await _loginButton.ClickAsync();
    }

}