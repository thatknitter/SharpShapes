﻿using System;
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
            Square square = new Square(20);
            Assert.AreEqual(20, square.Width);
            Assert.AreEqual(20, square.Height);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestSquareWidthSanityCheck()
        {
            Square square = new Square(0);
        }


        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestSquareConstructorWidthPositveSanityCheck()
        {
            Square square = new Square(-1);
        }

        [TestMethod]
        public void TestSquareScale200Percent()
        {
            Square square = new Square(20);
            square.Scale(200);
            Assert.AreEqual(40, square.Width);
            Assert.AreEqual(40, square.Width);
        }

        [TestMethod]
        public void TestSquareScale150Percent()
        {
            Square square = new Square(20);
            square.Scale(150);
            Assert.AreEqual(30, square.Width);
            Assert.AreEqual(30, square.Width);
        }

        [TestMethod]
        public void TestSquareScale37Percent()
        {
            Square square = new Square(20);
            square.Scale(37);
            Assert.AreEqual((decimal) 7.4, square.Width);
            Assert.AreEqual((decimal) 7.4, square.Height);

        }

        [TestMethod]
        public void TestSquareScaleUpAndDown()
        {
            Square square = new Square(20);
            square.Scale(50);
            square.Scale(200);
            Assert.AreEqual(20, square.Width);
            Assert.AreEqual(20, square.Height);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestSquareScale0Percent()
        {
            Square square = new Square(20);
            square.Scale(0);
        }

        [TestMethod]
        public void TestSquareScale100Percent()
        {
            Square square = new Square(20);
            square.Scale(100);
            Assert.AreEqual(20, square.Width);
            Assert.AreEqual(20, square.Height);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestSquareScaleNegativePercent()
        {
            Square square = new Square(20);
            square.Scale(-5);
        }

        [TestMethod]
        public void TestSquareSidesCount()
        {
            Square square = new Square(20);
            Assert.AreEqual(4, square.SidesCount);
        }

        [TestMethod]
        public void TestSquareArea()
        {
            Square square = new Square(20);
            Assert.AreEqual(400, square.Area());
        }

        [TestMethod]
        public void TestBiggerSquareArea()
        {
            Square square = new Square(40);
            Assert.AreEqual(1600, square.Area());
        }

        [TestMethod]
        public void TestSquarePerimeter()
        {
            Square square = new Square(20);
            Assert.AreEqual(80, square.Perimeter());
        }

        [TestMethod]
        public void TestBiggerSquarePerimeter()
        {
            Square square = new Square(40);
            Assert.AreEqual(160, square.Perimeter());
        }

        [TestMethod]
        public void TestDefaultColors()
        {
            Square shape = new Square(20);
            Assert.AreEqual(System.Drawing.Color.Tomato, shape.BorderColor);
            Assert.AreEqual(System.Drawing.Color.Bisque, shape.FillColor);

        }
    }
}
