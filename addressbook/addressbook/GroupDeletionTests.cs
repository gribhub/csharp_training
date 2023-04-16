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
            OpenHomepage();
            Login(new AccountData("admin", "secret"));
            GoToGroups();
            SelectGroup(1);
            DeleteGroup();
            ReturnToGroupsPage();
            Logout();
        }
    }
}
