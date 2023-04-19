using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;

namespace addressbook_web_tests
{
    public class ApplicationManager
    {
        protected LoginLogoutHelper loginLogoutHelper;
        protected NavHelper navHelper;
        protected GroupHelper groupHelper;
        protected IWebDriver driver;
        protected string baseURL;

        public LoginLogoutHelper LoginLogout
        {
            get
            {
                return loginLogoutHelper;
            }
        }

        public NavHelper Nav
        {
            get
            {
                return navHelper;
            }
        }

        public GroupHelper Group
        {
            get
            {
                return groupHelper;
            }
        }

        public ApplicationManager()
        {
            loginLogoutHelper = new LoginLogoutHelper(driver);
            navHelper = new NavHelper(driver, baseURL);
            groupHelper = new GroupHelper(driver);
        }

        public void Stop()
        {
            try
            {
                driver.Quit();
            }
            catch (Exception)
            {
                // Ignore errors if unable to close the browser
            }
        }
    }
}
