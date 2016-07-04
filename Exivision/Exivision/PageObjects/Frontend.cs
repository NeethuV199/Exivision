using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exivision.PageObjects
{
    class FrontEnd
    {
        #region Login
        //Login elements
        public string SigninLink = "aSignIn";
        public string UserNameField = "txtUserName";
        public string PasswordField = "txtPassword";
        public string ClickOnLogin = "BtnUserLogin";
        #endregion

        #region ForgotPasswordLink
        //ForgotPassword elements
        public string ForgotPasswordId = "aForgotPassword";
        #endregion

        #region AccountRequestFromSignin
        //AccountRequest elements
        public string AccountRequestId = "aCreateAccount";
        #endregion
    }
}
