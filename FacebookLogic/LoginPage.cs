using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FacebookLogic
{
    public class LoginPage
    {
        private readonly FacebookDataManager r_FacebookDataManager;

        public LoginPage()
        {
            r_FacebookDataManager = FacebookDataManager.Instance;
        }

        public void Login()
        {
            r_FacebookDataManager.Login();
        }
    }
}
