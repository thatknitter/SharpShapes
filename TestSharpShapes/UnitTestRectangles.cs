using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestSharpShapes
{
    [TestClass]
    public class UnitTestRectangles
    {
        [TestMethod]
        public void TestRectangleConstructor()
        {
            Rectangle rectangle = new Rectangle(40, 50);
            Assert.AreEqual(40, rectangle.Width);
            Assert.AreEqual(50, rectangle.Height);
        }

        [TestMethod]
        [ExpectedException(ArgumentException)]
        public void TestRectangleConstructorSanityChecksValues()
        {
            Rectangle rectangle = new Rectangle(0, 50);   
        }

        [TestMethod]
        [ExpectedException(ArgumentException)]
        public void TestRectangleConstructorRequiresValues()
        {
            Rectangle rectangle = new Rectangle();
        }
    }
}
