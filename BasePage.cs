using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace AutomatedTestsRefresh
{
    public class BasePage
    {
        public IWebDriver Driver { get; set; }

        public void Init()
        {
            Driver = new ChromeDriver();
        }
    }
}
