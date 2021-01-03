using NUnit.Framework;
using OpenQA.Selenium;

namespace AutomatedTestsRefresh
{
    public class TestsPage: BasePage
    {
        private PracticeFormPage formPage;

        [SetUp]
        public void Setup()
        {
            Init();
            Driver.Url = "https://demoqa.com/";
            Driver.Manage().Window.Maximize();
            formPage = new PracticeFormPage(Driver);
        }

        [TearDown]
        public void TearDown() 
        {
            Driver.Quit();
        }

        [Test]
        public void HomePage()
        {
            var user = FormModels.Create();
            formPage.FillForm(user);

            Assert.AreEqual("Thanks for submitting the form", formPage.CompleteForm.Text);
            
        }
    }
}