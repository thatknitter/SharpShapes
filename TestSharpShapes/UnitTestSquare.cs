using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SharpShapes;

namespace TestSharpShapes
{
    [TestClass]
    public class UnitTestSquare
    {
        [TestMethod]
        public void TestSquareConstructor()
        {
            Square square = new Square(20, 90);
            Assert.AreEqual(20, square.edgeLength);
            
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestSquareedgeLengthSanityCheck()
        {
            Square square = new Square(0, 90);
        }


        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestSquareConstructoredgeLengthPositveSanityCheck()
        {
            Square square = new Square(-1, 90);
        }

        [TestMethod]
        public void TestSquareScale200Percent()
        {
            Square square = new Square(20, 90);
            square.Scale(200);
            Assert.AreEqual(40, square.edgeLength);
            
        }

        [TestMethod]
        public void TestSquareScale150Percent()
        {
            Square square = new Square(20, 90);
            square.Scale(150);
            Assert.AreEqual(30, square.edgeLength);
            
        }

        [TestMethod]
        public void TestSquareScale37Percent()
        {
            Square square = new Square(20, 90);
            square.Scale(37);
            Assert.AreEqual((decimal) 7.4, square.edgeLength);

        }

        [TestMethod]
        public void TestSquareScaleUpAndDown()
        {
            Square square = new Square(20, 90);
            square.Scale(50);
            square.Scale(200);
            Assert.AreEqual(20, square.edgeLength);
            
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestSquareScale0Percent()
        {
            Square square = new Square(20, 90);
            square.Scale(0);
        }

        [TestMethod]
        public void TestSquareScale100Percent()
        {
            Square square = new Square(20, 90);
            square.Scale(100);
            Assert.AreEqual(20, square.edgeLength);
            
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestSquareScaleNegativePercent()
        {
            Square square = new Square(20, 90);
            square.Scale(-5);
        }

        [TestMethod]
        public void TestSquareSidesCount()
        {
            Square square = new Square(20, 90);
            Assert.AreEqual(4, square.SidesCount);
        }

        [TestMethod]
        public void TestSquareArea()
        {
            Square square = new Square(20, 90);
            Assert.AreEqual(400, square.Area());
        }

        [TestMethod]
        public void TestBiggerSquareArea()
        {
            Square square = new Square(40, 90);
            Assert.AreEqual(1600, square.Area());
        }

        [TestMethod]
        public void TestSquarePerimeter()
        {
            Square square = new Square(20, 90);
            Assert.AreEqual(80, square.Perimeter());
        }

        [TestMethod]
        public void TestBiggerSquarePerimeter()
        {
            Square square = new Square(40, 90);
            Assert.AreEqual(160, square.Perimeter());
        }

        [TestMethod]
        public void TestDefaultColors()
        {
            Square shape = new Square(20, 90);
            Assert.AreEqual(System.Drawing.Color.Tomato, shape.BorderColor);
            Assert.AreEqual(System.Drawing.Color.Bisque, shape.FillColor);

        }
    }
}
