using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestSharpShapes
{
    [TestClass]
    public class UnitTestTrapezoid
    {
        [TestMethod]
        public void TestTrapezoidConstructor()
        {
            Trapezoid trapezoid = new Trapezoid(20, 10, 60, 120);
            Assert.AreEqual(20, trapezoid.Width);
            Assert.AreEqual(10, trapezoid.Height);
            Assert.AreEqual(60, trapezoid.BottomAngle);
            Assert.AreEqual(120, trapezoid.TopAngle);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestTrapezoidSanityCheckWidth()
        {
            Trapezoid trapezoid = new Trapezoid(0, 10, 60, 120);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestTrapezoidSanityCheckWidthPositve()
        {
            Trapezoid trapezoid = new Trapezoid(-1, 10, 60, 120);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestTrapezoidSanityCheckHeight()
        {
            Trapezoid trapezoid = new Trapezoid(20, 0, 60, 120);
        }

        TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestTrapezoidSanityCheckHeightPositve()
        {
            Trapezoid trapezoid = new Trapezoid(20, -1, 60, 120);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestTrapezoidSantiyCheckTopAngle()
        {
            Trapezoid trapezoid = new Trapezoid(20, 10, 60, 0);
        }

        TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestTrapezoidSanityCheckTopAnglePositve()
        {
            Trapezoid trapezoid = new Trapezoid(20, 10, 60, -1);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestTrapezoidSanityCheckBottomAngle()
        {
            Trapezoid trapezoid = new Trapezoid(20, 10, 0, 120);
        }

        TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestTrapezoidSanityCheckBottomAnglePositve()
        {
            Trapezoid trapezoid = new Trapezoid(20, 10, -1, 120);
        }

        [TestMethod]
        public void TestTrapezoidAnglesAddUp()
        {
            Trapezoid trapezoid = new Trapezoid(20, 10, 60, 120);
            Assert.AreEqual(180, trapezoid.AddAngles);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestTrapezoidAnglesSanityCheck()
        {
            Trapezoid trapezoid = new Trapezoid(20, 10, 60, 110);
        }



    }
}
