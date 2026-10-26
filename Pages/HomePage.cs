using Microsoft.Playwright;

namespace template_playwright_csharp.Pages;

public class HomePage
{
    private readonly IPage _page;
    public ILocator ShoppingCart { get; }

    public HomePage(IPage page)
    {
        _page = page;
        ShoppingCart = _page.Locator("#shopping_cart_container");
    }

}