using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AutomatedTestsRefresh
{
    public partial class PracticeFormPage
    {
        private IWebDriver _driver;
        public WebDriverWait Wait { get; }

        public Actions Builder { get; }


        public PracticeFormPage(IWebDriver driver)
        {
            _driver = driver;

            Wait = new WebDriverWait(driver, TimeSpan.FromSeconds(60));
           
            Builder = new Actions(driver);

        }

        public void ScrollTo(IWebElement element)
        {
            ((IJavaScriptExecutor)_driver).ExecuteScript("arguments[0].scrollIntoView(true);", element);
        }
    }
}
