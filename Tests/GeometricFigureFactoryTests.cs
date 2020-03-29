using GeometricFigureFactoryLib;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Tests
{
    [TestClass]
    public class GeometricFigureFactoryTests
    {
        [TestMethod]
        [DataRow(null)]
        [ExpectedException(typeof(NullReferenceException))]
        public void GetArea_SetGeometricFigureIsNull_ReturnNullReferenceException(GeometricFigure triangle) {
            GeometricFigureFactory.GetArea(triangle);

        }
        [TestMethod]
        [DataRow(null)]
        [ExpectedException(typeof(NullReferenceException))]
        public void IsRectangularTriangle_SetTriangleIsNull_ReturnNullReferenceException(Triangle triangle) {
            GeometricFigureFactory.GetArea(triangle);

        }

    }
}
