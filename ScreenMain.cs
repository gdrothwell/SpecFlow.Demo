using OpenQA.Selenium;

namespace SpecFlow.Demo;

public class ScreenMain
{
    public By ShoppingItem(string item) => By.LinkText(item);
}