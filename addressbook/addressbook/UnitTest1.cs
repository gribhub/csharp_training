using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace addressbook_web_tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethodSquare()
        {
            Square s1 = new Square(5);
            Square s2 = new Square(-8);
            Square s3 = s1;

            s2.Colored = true;

            Assert.AreEqual(s1.Size, 5);

            s3.Size = 15;

            Assert.AreEqual(s1.Size, 15);
        }

        [TestMethod]
        public void TestMethodCircle()
        {
            Circle c1 = new Circle(5);
            Circle c2 = new Circle(-8);
            Circle c3 = c1;

            c2.Colored = true;

            Assert.AreEqual(c1.Radius, 5);

            c3.Radius = 15;

            Assert.AreEqual(c1.Radius, 15);
        }
    }
}