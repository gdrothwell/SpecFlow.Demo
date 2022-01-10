using TechTalk.SpecFlow;
namespace SpecFlow.Demo;

[Binding]
public class StepDefinitions
{
    private readonly Tasks _tasks;

    public StepDefinitions(BrowserDriver browserDriver)
    {
        _tasks = new Tasks(browserDriver.Current);
    }

    [Given(@"I select the item named (.*)")]
    public void GivenISelectTheItemNamed(string p0)
    {
        var screenMain = new ScreenMain();
        _tasks.ScrollToItem(screenMain.ShoppingItem(p0));
        _tasks.Click(screenMain.ShoppingItem(p0));    
    }
    
    [Given(@"I select the color (.*)")]
    public void GivenISelectTheColor(string p0)
    {
        //
    }
    
    [Given(@"I select size (.*)")]
    public void GivenISelectSize(int p0)
    {
        //
    }
    
    [Given(@"I add the selected item to cart")]
    public void GivenIAddTheSelectedItemToCart()
    {
        //
    }
    
    [When(@"I go to the shopping cart")]
    public void WhenIGoToTheShoppingCart()
    {
        //
    }
    
    [Then(@"I see the item named (.*)")]
    public void ThenISeeTheItemNamed(string p0)
    {
        //
    }
    
    [Then(@"I see the item is of color (.*)")]
    public void ThenISeeTheItemIsOfColor(string p0)
    {
        //
    }
    
    [Then(@"I see the item is of size (.*)")]
    public void ThenISeeTheItemIsOfSize(int p0)
    {
        //
    }
}