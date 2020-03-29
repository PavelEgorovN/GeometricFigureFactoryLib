using GeometricFigureFactoryLib;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Tests
{
    [TestClass]
    public class CircleTests
    {
        [TestMethod]
        public void CreateCircle_SetRadius_ReturnValidArea() {
            var circle = new Circle(1);

            var result = GeometricFigureFactory .GetArea(circle);

            Assert.AreEqual(Math.PI, result, 0.000000000001);
        }
        [DataTestMethod]
        [DataRow(0)]
        [ExpectedException(typeof(ArgumentException))]
        public void CreateCircle_SetWrongRadius_ThrowArgumentException(double r) {
            new Circle(r);
        }
       

    }
}
