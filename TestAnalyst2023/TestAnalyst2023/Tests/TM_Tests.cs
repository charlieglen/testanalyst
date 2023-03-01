
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.DevTools.V108.WebAuthn;
using System.ComponentModel.DataAnnotations;
using System.Threading;
using System.Timers;
using System.Globalization;
using TestAnalyst2023.Pages;
using TestAnalyst2023.Utilities;
using NUnit.Framework;
using static System.Net.Mime.MediaTypeNames;

namespace TestAnalyst2023.Tests
{
    [TestFixture]
    public class TM_Tests : CommonDriver
    {
        [SetUp]
        public void LoginSteps()
        {
            // Open Chrome Browser
            driver = new ChromeDriver();

            // Log in page object initializationa dn definiation
            LoginPage loginPageObj = new LoginPage();
            loginPageObj.LoginActions(driver);

            // Home page object initialization andd defination
            HomePage homePageObj = new HomePage();
            homePageObj.GoToTMPage(driver);
        }
        [Test]
        public void CreateTMTest()
        {

            // TM page object initialization andd definition
            TMPage tmPageObj = new TMPage();
            tmPageObj.CreateTM(driver);

        }

        [Test]
        public void EditTMTest()
        {
            // Edit TM
            TMPage tmPageObj = new TMPage();
            tmPageObj.EditTM(driver);

        }
        [Test]
        public void DeleteTMTest()
        {
            // Delete TM
            TMPage tmPageObj = new TMPage();
            tmPageObj.DeleteTM(driver);

        }
        [TearDown]
        public void CloseTestRun()
        { 
        
        }

    }
}


























