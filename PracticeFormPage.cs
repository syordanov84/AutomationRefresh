using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AutomatedTestsRefresh
{
    class PracticeFormPage
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


        public List<IWebElement> Form => _driver.FindElements(By.ClassName("avatar")).ToList();
        public List<IWebElement> FormBtn => Wait.Until(w => w.FindElements(By.Id("item-0")).ToList());
        public IWebElement FirstName => Wait.Until(w => w.FindElement(By.Id("firstName")));
        public IWebElement LastName => _driver.FindElement(By.Id("lastName"));
        public IWebElement UserEmail => _driver.FindElement(By.Id("userEmail"));
        public List<IWebElement> RadioCheckbox => _driver.FindElements(By.ClassName("custom-control-label")).ToList();
        public IWebElement UserNumber => _driver.FindElement(By.Id("userNumber"));
        public IWebElement DateOfBirth => _driver.FindElement(By.Id("dateOfBirthInput"));
        public IWebElement Subjects => Wait.Until(w => w.FindElement(By.Id("subjectsInput")));
        public IWebElement SportsCheckbox => _driver.FindElement(By.CssSelector(".custom-control-label::after"));
        public IWebElement SelectJune => _driver.FindElement(By.XPath("//option[@value='5']"));
        public IWebElement SelectYear => _driver.FindElement(By.XPath("//option[@value='1984']"));
        public IWebElement CompleteForm => Wait.Until(w => w.FindElement(By.Id("example-modal-sizes-title-lg")));
        public IWebElement Submit => _driver.FindElement(By.Id("submit"));
        public List<IWebElement> SelectDate => _driver.FindElements(By.ClassName("react-datepicker__day--006")).ToList();


        public void FillForm(Models user)
        {
            Form[1].Click();
            FormBtn[1].Click();
            FirstName.SendKeys(user.FirstName);
            LastName.SendKeys(user.LastName);
            UserEmail.SendKeys(user.UserEmail);
            RadioCheckbox[0].Click();
            UserNumber.SendKeys(user.UserNumber);
            DateOfBirth.Click();
            SelectJune.Click();
            SelectYear.Click();
            SelectDate[0].Click();
            //for (int i = 0; i < 11; i++)
            //{
            //    formPage.Subjects.SendKeys(Keys.Backspace);
            //}
            //formPage.DateOfBirth.SendKeys("01 02 1982");
            //formPage.DateOfBirth.SendKeys(Keys.Escape);
            Subjects.Click();
            Subjects.SendKeys(user.Subjects);
            RadioCheckbox[3].Click();
            Submit.Click();
        }











    }
}
