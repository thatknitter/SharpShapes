using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SharpShapes;

namespace TestSharpShapes
{
    [TestClass]
    public class UnitTestTrapezoid
    {
        [TestMethod]
        public void TestTrapezoidConstructor()
        {
            Trapezoid trapezoid = new Trapezoid(20, 15, 10, 75, 105);
            Assert.AreEqual(20, trapezoid.BottomWidth);
            Assert.AreEqual(10, trapezoid.Height);
            Assert.AreEqual(15, trapezoid.TopWidth);
            Assert.AreEqual(75, trapezoid.BottomAngle);
            Assert.AreEqual(105, trapezoid.TopAngle);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestTrapezoidSanityCheckWidth()
        {
            Trapezoid trapezoid = new Trapezoid(0, 15, 10, 75, 105);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestTrapezoidSanityCheckWidthPositve()
        {
            Trapezoid trapezoid = new Trapezoid(-1, 15, 10, 75, 105);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestTrapezoidSanityCheckHeight()
        {
            Trapezoid trapezoid = new Trapezoid(20, 15, 0, 75, 105);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestTrapezoidSanityCheckHeightPositve()
        {
            Trapezoid trapezoid = new Trapezoid(20, 15, -1, 75, 105);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestTrapezoidSantiyCheckTopAngle()
        {
            Trapezoid trapezoid = new Trapezoid(20, 15, 10, 75, 0);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestTrapezoidSanityCheckTopAnglePositve()
        {
            Trapezoid trapezoid = new Trapezoid(20, 15, 10, 75, -1);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestTrapezoidSanityCheckBottomAngle()
        {
            Trapezoid trapezoid = new Trapezoid(20, 15, 10, 0, 105);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestTrapezoidSanityCheckBottomAnglePositve()
        {
            Trapezoid trapezoid = new Trapezoid(20, 15, 10, -1, 105);
        }

        [TestMethod]
        public void TestTrapezoidAnglesAddUp()
        {
            Trapezoid trapezoid = new Trapezoid(20, 15, 10, 75, 105);
            Assert.AreEqual(180, trapezoid.AddAngles);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestTrapezoidAnglesSanityCheck()
        {
            Trapezoid trapezoid = new Trapezoid(20, 15, 10, 75, 110);
        }

        [TestMethod]
        public void TestTrapezoidPerimeter()
        {
            Trapezoid trapezoid = new Trapezoid(20, 15, 10, 75, 105);
            Assert.AreEqual(75, trapezoid.Perimeter());
        }

        [TestMethod]
        public void TestTrapezoidBiggerPerimeter()
        {
            Trapezoid trapezoid = new Trapezoid(40, 35, 30, 75, 105);
            Assert.AreEqual(140, trapezoid.Perimeter());
        }

        [TestMethod]
        public void TestTrapezoidScale200()
        {
            Trapezoid trapezoid = new Trapezoid(20, 15, 10, 75, 105);
            trapezoid.Scale(200);
            Assert.AreEqual(40, trapezoid.Width);
            Assert.AreEqual(20, trapezoid.Height);
            Assert.AreEqual(75, trapezoid.BottomAngle);
            Assert.AreEqual(105, trapezoid.TopAngle);
        }

        [TestMethod]
        public void TestTrapezoidScale150()
        {
            Trapezoid trapezoid = new Trapezoid(20, 15, 10, 75, 105);
            trapezoid.Scale(150);
            Assert.AreEqual(40, trapezoid.Width);
            Assert.AreEqual(20, trapezoid.Height);
            Assert.AreEqual(75, trapezoid.BottomAngle);
            Assert.AreEqual(105, trapezoid.TopAngle);
        }

        [TestMethod]
        public void TestTrapezoidScale37()
        {
            Trapezoid trapezoid = new Trapezoid(20, 15, 10, 75, 105);
            trapezoid.Scale(37);
            Assert.AreEqual(40, trapezoid.Width);
            Assert.AreEqual(20, trapezoid.Height);
            Assert.AreEqual(75, trapezoid.BottomAngle);
            Assert.AreEqual(105, trapezoid.TopAngle);
        }

        [TestMethod]
        public void TestTrapezoidScaleUpAndDown()
        {
            Trapezoid trapezoid = new Trapezoid(20, 15, 10, 75, 105);
            trapezoid.Scale(50);
            trapezoid.Scale(200);
            Assert.AreEqual(20, trapezoid.Width);
            Assert.AreEqual(10, trapezoid.Height);
            Assert.AreEqual(75, trapezoid.BottomAngle);
            Assert.AreEqual(105, trapezoid.TopAngle);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestTrapezoidScale0()
        {
            Trapezoid trapezoid = new Trapezoid(20, 15, 10, 75, 105);
            trapezoid.Scale(0);
        }

        [TestMethod]
        public void TestTrapezoidScale100()
        {
            Trapezoid trapezoid = new Trapezoid(20, 15, 10, 75, 105);
            trapezoid.Scale(100);
            Assert.AreEqual(20, trapezoid.Width);
            Assert.AreEqual(10, trapezoid.Height);
            Assert.AreEqual(75, trapezoid.BottomAngle);
            Assert.AreEqual(105, trapezoid.TopAngle);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestTrapezoidNegativeScale()
        {
            Trapezoid trapezoid = new Trapezoid(20, 15, 10, 75, 105);
            trapezoid.Scale(-5);
        }

        [TestMethod]
        public void TestTrapezoidSidesCount()
        {
            Trapezoid trapezoid = new Trapezoid(20, 15, 10, 75, 105);
            Assert.AreEqual(4, trapezoid.SidesCount());
        }

        [TestMethod]
        public void TestTrapezoidArea()
        {
            Trapezoid trapezoid = new Trapezoid(20, 15, 10, 75, 105);
            Assert.AreEqual(100, trapezoid.Area());
        }

        [TestMethod]
        public void TestTrapezoidBiggerArea()
        {
            Trapezoid trapezoid = new Trapezoid(40, 35, 30, 75, 105);
            Assert.AreEqual(100, trapezoid.Area());
        }

        [TestMethod]
        public void TestTrapezoidDefaultColors()
        {
            Trapezoid trapezoid = new Trapezoid(20, 15, 10, 75, 105);
            Assert.AreEqual(System.Drawing.Color.Tomato, shape.BorderColor);
            Assert.AreEqual(System.Drawing.Color.Bisque, shape.FillColor);
        }

    }
}
