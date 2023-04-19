using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;

namespace addressbook_web_tests
{
    [TestFixture]
    public class GroupDeletionTests : TestBase
    {
        [Test]
        public void GroupDeletionTest()
        {
            app.Nav.OpenHomepage();
            app.LoginLogout.Login(new AccountData("admin", "secret"));
            app.Nav.GoToGroups();
            app.Group.SelectGroup(1);
            app.Group.DeleteGroup();
            app.Group.ReturnToGroupsPage();
            app.LoginLogout.Logout();
        }
    }
}
