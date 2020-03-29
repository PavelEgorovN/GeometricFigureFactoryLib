using GeometricFigureFactoryLib;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;


namespace Tests
{
    [TestClass]
    public class TriangleTests
    {
        [TestMethod]
        public void CreateTriangle_SetSides_ReturnArea() {
            var triangle = new Triangle(4, 4, 4);

            var result = GeometricFigureFactory.GetArea(triangle);

            Assert.AreEqual(6.928203230275509, result);
        }

        [DataTestMethod]
        [DataRow(0, 2, 3)]
        [DataRow(1, 0, 3)]
        [DataRow(1, 2, 0)]
        [ExpectedException(typeof(ArgumentException))]
        public void CreateTriangle_SetSides_ReturnArgumentException(double sideA, double sideB, double sideC) {
            new Triangle(sideA, sideB, sideC);
        }

        [DataTestMethod]
        [DataRow(3, 4, 5)]
        [DataRow(4, 3, 5)]
        [DataRow(5, 4, 3)]
        public void IsRectangle_SetSides_ReturnTrue(double sideA, double sideB, double sideC) {
            var triangle = new Triangle(sideA, sideB, sideC);
            var result = triangle.IsRectangular();
            Assert.IsTrue(result);
        }

        [DataTestMethod]
        [DataRow(2, 2, 2)]
        [DataRow(3, 3, 3)]
        [DataRow(4, 4, 4)]
        public void IsRectangle_SetSides_ReturnFalse(double sideA, double sideB, double sideC) {
            var triangle = new Triangle(sideA, sideB, sideC);
            var result = triangle.IsRectangular();
            Assert.IsFalse(result);
        }

    }
}
