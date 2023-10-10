using Microsoft.Playwright;
using Microsoft.Playwright.NUnit;

namespace SampleGHActions;

public class Tests: PageTest
{
    [SetUp]
    public void Setup()
    {
        Page.GotoAsync("https://demo.playwright.dev/todomvc/#/");
    }

    [Test]
    public async Task HasCorrectMainH1Title()
    {
        var getStarted = Page.GetByText("todos");
        await Expect(getStarted).ToBeVisibleAsync();
    }
}