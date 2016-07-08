using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

using System.Runtime.InteropServices;

namespace Exivision.SourceCode
{

    [TestFixture]
    public class LoginTest : Login
    {
        [TearDown]
        public void TeardownTest()
        {
            try
            {
                driver.Quit();
            }
            catch (Exception)
            {
                // Ignore errors if unable to close the browser
            }
            //Assert.AreEqual("", verificationErrors.ToString());
        }
        [Test]
        public void TheObjectTest()
        {
            SetUp();
            driver.Navigate().GoToUrl(baseURL + "/");
            delenit(); //Navigate to ABOUT screen from DELENIT AUGUE DUIS button from homescreen
            driver.Close();
        }
        
    }   
}

