
using OpenQA.Selenium;
using Exivision.SourceCode;
using System;
using Exivision.PageObjects;
using OpenQA.Selenium.Support.UI;

namespace Exivision.SourceCode
{
    public class Login : Main
    {
        public Login(IWebDriver Obj)
        {
            driver = Obj;
        }
        public Login()
        {
            
        }
        public void delenit()
        {
            //wait.Until(ExpectedConditions.ElementIsVisible(By.LinkText(FrontEnd.delenitlink)));
            driver.FindElement(By.LinkText("DELENIT AUGUE DUIS")).Click();
        }
}
}
