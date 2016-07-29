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
    public class FrontTest : Front
    {

        [Test]
        public void TheObjectTest()
        {
            #region

            //URL STARTUP
            SetUp();
            driver.Navigate().GoToUrl(baseURL + "/");
            WaitForPageLoad(10000);

            //FRONTEND LINKS
            delenitlink(); //Navigate to ABOUT screen from DELENIT AUGUE DUIS button from homescreen

            KonecranesHeader();

            //COURSE SUBLINKS
            TechnicalCourses();
            SystemCourse();
            ProductTrainingCourse();
            OperatorTrainingCourse();
            EcoDriving();
            driver.Close();
            #endregion
        }

    }   
}

