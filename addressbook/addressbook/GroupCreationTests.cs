﻿using System;
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
            OpenHomepage();
            Login(new AccountData("admin", "secret"));
            GoToGroups();
            InitGroupCreation();
            FillGroupForm(new GroupData("q", "q", "q"));
            SubmitGroupCreation();
            Logout();
        }
    }
}
