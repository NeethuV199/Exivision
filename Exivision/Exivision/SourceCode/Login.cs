
using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using Exivision.PageObjects;

namespace Exivision.SourceCode
{
    class Login
    {
        public object driver;
        private WebDriverWait wait;

        public object ExpectedConditions { get; private set; }

        public void DelenitAugueDuis()
        {
           //wait = new WebDriverWait(driver, new TimeSpan(50));
           wait.Until.ExpectedConditions.el(By.CssSelector(FrontEnd.delenitcss)).click();
           
        }
    }

    
}
