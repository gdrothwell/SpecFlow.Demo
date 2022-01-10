namespace SpecFlow.Demo;
using TechTalk.SpecFlow;

[Binding]
public class BeforeHooks
{
    [BeforeScenario]
    public static void SetUp()
    {
        var browserDriver = new BrowserDriver();
    }
}