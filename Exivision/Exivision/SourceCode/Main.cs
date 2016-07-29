using System;
using System.Diagnostics;
using System.Threading;
using NUnit.Framework;
using System.Xml.Xsl;
using System.Xml;
using System.IO;
using Selenium;
using System.Text;
using System.Globalization;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using Exivision.PageObjects;
using Exivision.SourceCode;

namespace Exivision.SourceCode
{
    public class Main
    {
        public IWebDriver driver;
        public WebDriverWait wait;
        public FrontEnd FrontEnd = new FrontEnd();
        public string baseURL;

        public void SetUp()
        {
            driver = new FirefoxDriver();
            driver. Manage().Window.Maximize();
            baseURL = "http://dev.exivision.info/";
        }

     /*   public void WaitForTextInDiffLang(string eng, string swe)
        {
            if (driver.FindElement(By.XPath("//a[@href='/Home/Contact']")).Text == "KONTAKT")
            {
                WaitForTextPresent(swe);
            }
            else
            {
                WaitForTextPresent(eng);
            }
        }*/



    /*    public void WaitForTextPresent(String text)
        {
            try
            {
                for (int sec = 0; sec < 100; sec++)
                {
                    if (IsTextPresent(text))
                        break;
                    Thread.Sleep(1000);
                }
                if (!IsTextPresent(text))
                    throw new Exception(text + "  Not Found");
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("ERROR: Couldn't access document.body.  Is this HTML page fully loaded?"))
                {
                    driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromMinutes(1));

                }
                else
                    throw new Exception(ex.Message);
            }

        }

        public Boolean IsTextPresent(String text)
        {
            bool present = false;
            for (int seconds = 0; seconds <= 100; seconds++)
            {
                if (driver.PageSource.Contains(text).Equals(true))
                {
                    return true;
                    break;
                }
                else
                {
                    return false;
                }
                break;
            }
            if (present == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }*/


        public void WaitForPageLoad(double timeOut)
        {
            driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromMilliseconds(timeOut));
        }

    }

}
