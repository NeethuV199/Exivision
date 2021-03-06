﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exivision.SourceCode;

namespace Exivision.PageObjects
{
    public class FrontEnd
    {

        #region Signin
        //Signin elements
        public string LoginLink = "aSignIn";
        public string LoginUsername= "txtUserName";
        public string LoginPassword = "txtPassword";
        public string LoginButton = "BtnUserLogin";
        #endregion

        #region ForgotPasswordLink
        //ForgotPassword elements
        public string ForgotPasswordId = "aForgotPassword";
        #endregion

        #region AccountRequestFromSignin
        //AccountRequest elements
        public string ARId = "aCreateAccount";
        public string ARJobTitleField = "JobTitle";
        public string ARFirstNameField = "FirstName";
        public string ARLastNameField = "LastName";
        public string ARUserNameField = "UserName";
        public string ARPasswordField = "Password";
        public string ARConfirmPasswordField = "ConfirmPassword";
        public string ARTitle = "UserTitleID";
        public string AREmail = "EmailID";
        public string ARTelephone = "Telephone";
        public string ARCompanyName = "CompanyName";
        public string ARStreet = "Street";
        public string ARPoBox = "POBox";
        public string ARPostalCode = "PostalCode";
        public string ARCity = "ARCity";
        public string ARCountry = "CountryID";
        public string ARWebsite = " Website";
        public string ARChosseFile = "btn-browse-image2";
        public string ARSubmit = "btn-save-register";
        public string ARClose = "close-reveal-modal1";
        #endregion

        #region Global
        //Global Link
        public string GlobalLink = "select_country";
        public string Globalsite1 = "http://www.konecranes.com";
        public string Globalsite2 = "http://www.kclifttrucks.com";
        public string GlobalLanguageEnglish = "/Home/ChangeLanguage? language = en";
        public string GlobalLanguageSwedish = "/Home/ChangeLanguage?language=sv";
        public string GlobalClose = "close-btn";
        #endregion

        #region Search
        //Frontend Search
        public string Search = "search_ico";
        public string SearchField = "txtSearchTextBox";
        #endregion

        #region Courses
        //Courses from Frontend
        public string Course_Technical = "//a[contains(text(),'COURSES')]"; //XPATH //a[contains(text(),'Technical Training')]
        public string Course_SystemTraining = "//a[contains(text(),'SYSTEM TRAINING')]";    //XPATH
        public string Course_ProductTraining = "//a[contains(text(),'PRODUCT TRAINING')]";   //XPATH
        public string Course_OperatorTraining = "//a[contains(text(),'OPERATOR TRAINING')]";    //XPATH
        public string Course_EcoDrivingTraining = "//a[contains(text(), 'ECODRIVING')]";    //XPATH
        #endregion

        #region Contact
        //Contact from frontend
        public string Contact_FRONTSCREEN = "//a[contains(text(),'CONTACT')]";    //XPATH
        #endregion

        #region Lift Truck Academy
        //Lift Truck Academy From Frontend
        public string LiftTruckAcademy_FRONTEND = "//a[contains(text(), 'LIFT TRUCK ACADEMY')]";    //XPATH
        #endregion

        #region About
        //About from frontend
        public string About_href = "/Home/About";
        public string About_hrefTheTeam = "/Home/Team";
        public string About_hrefQuality = "/Home/Quality";
        #endregion

        #region Delenit Augue Duis

        //Delenit Augue Duis from frontend

        public string delenit = "READ MORE";  //linkText

        #endregion

        #region Konecranes(header)
        //Konecranes(header) from frontend
        public string KonecranesHead = "img.img-responsive";  //css selector
        #endregion

        #region Konecranes(footer)
        //Konecranes(footer) from frontend
        public string Courses_TechnicalTraining_Footer = "//a[contains(text(), 'Technical Training')]"; //xpath
        public string Courses_SystemTraining_Footer = "//a[contains(text(), 'System Training')]";   //xpath
        public string Courses_ProductTraining_Footer = "//a[contains(text(), 'Product Training')]"; //xpath
        public string Courses_OperatorTraining_Footer = "//a[contains(text(), 'Operator Training')]";   //xpath
        public string Courses_EcoDriving_Footer = "//a[contains(text(), 'EcoDriving')]";    //xpath


        public string konecranes_footer = "//div/a/img";     //xpath
        #endregion
    }
}
