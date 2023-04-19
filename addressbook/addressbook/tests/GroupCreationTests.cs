using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;

namespace addressbook_web_tests
{
    [TestFixture]
    public class GroupCreationTests : TestBase
    {        
        [Test]
        public void GroupCreationTest()
        {
            app.Nav.OpenHomepage();
            app.LoginLogout.Login(new AccountData("admin", "secret"));
            app.Nav.GoToGroups();
            app.Group.InitGroupCreation();
            app.Group.FillGroupForm(new GroupData("q", "q", "q"));
            app.Group.SubmitGroupCreation();
            app.LoginLogout.Logout();
        }
    }
}
