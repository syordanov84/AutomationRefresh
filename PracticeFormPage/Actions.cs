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
