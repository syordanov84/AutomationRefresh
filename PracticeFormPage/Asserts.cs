using NUnit.Framework;
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
        public void AssertTestForm()
        {          
            Assert.AreEqual("Thanks for submitting the form", CompleteForm.Text);
        }

    }
}
