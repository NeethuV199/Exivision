
using OpenQA.Selenium;
using Exivision.SourceCode;
using System;
using Exivision.PageObjects;
using OpenQA.Selenium.Support.UI;

namespace Exivision.SourceCode
{
    public class Front : Main
    {
        public Front(IWebDriver Obj)
        {
            driver = Obj;
        }
        public Front()
        {
            
        }

        #region
        //FrontEnd

        public void delenitlink()
        {
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
            wait.Until(ExpectedConditions.ElementIsVisible(By.LinkText(FrontEnd.delenit)));
            driver.FindElement(By.LinkText(FrontEnd.delenit)).Click();
        }
       public void KonecranesHeader()
        {
            wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector(FrontEnd.KonecranesHead)));
            driver.FindElement(By.CssSelector(FrontEnd.KonecranesHead)).Click();
        }

        //FRONTEND COURSES AND ITS SUB LINKS
        public void TechnicalCourses()
        {
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath(FrontEnd.Course_Technical)));
            driver.FindElement(By.XPath(FrontEnd.Course_Technical)).Click();
        }

        public void SystemCourse()
        {
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath(FrontEnd.Course_SystemTraining)));
            driver.FindElement(By.XPath(FrontEnd.Course_SystemTraining)).Click();
        }

        public void ProductTrainingCourse()
        {
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath(FrontEnd.Course_ProductTraining)));
            driver.FindElement(By.XPath(FrontEnd.Course_ProductTraining)).Click();
        }

        public void OperatorTrainingCourse()
        {
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath(FrontEnd.Course_OperatorTraining)));
            driver.FindElement(By.XPath(FrontEnd.Course_OperatorTraining)).Click();
        }

        public void EcoDriving()
        {
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath(FrontEnd.Course_EcoDrivingTraining)));
            driver.FindElement(By.XPath(FrontEnd.Course_EcoDrivingTraining)).Click();
        }
        #endregion
    }
}
