namespace SpecFlow.Demo;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;

public class Tasks
{
    private readonly IWebDriver _webDriver;

    public Tasks(IWebDriver webDriver)
    {
        _webDriver = webDriver;
    }

    public void ScrollToItem(By selector, int time = 10)
    {
        Actions actions = new Actions(_webDriver);
        WebDriverWait wait = new WebDriverWait(_webDriver, TimeSpan.FromSeconds(time));
        var element = wait.Until(e => e.FindElement(selector));
        actions.MoveToElement(element).Perform();
    }

    public void Click(By selector, int time = 10)
    {
        WebDriverWait wait = new WebDriverWait(_webDriver, TimeSpan.FromSeconds(time));
        wait.Until(e => e.FindElement(selector)).Click();
    }
}