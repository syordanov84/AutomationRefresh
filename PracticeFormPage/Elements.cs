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
    }
}
