using System;

namespace GeometricFigureFactoryLib
{
    /// <summary>
    /// The class is engaged in the calculation of geometric shapes.
    /// </summary>
    public class GeometricFigureFactory 
    {
        /// <summary>
        /// The method gets the area of the geometric shape.
        /// </summary>
        /// <param name="geometricFigure">The geometric figure.</param>
        /// <returns>System.Double.</returns>
        /// <exception cref="System.NullReferenceException"></exception>
        public static double GetArea(GeometricFigure geometricFigure) => 
            (geometricFigure != null) ? geometricFigure.GetArea() : throw new NullReferenceException("The geometric figure must contain a reference to the object");
        /// <summary>
        /// The method gets the area a triangle if there are three sides.
        /// </summary>
        /// <param name="sideA">The side A.</param>
        /// <param name="sideB">The side B.</param>
        /// <param name="sideC">The side C.</param>
        /// <returns>System.Double.</returns>
        public static double GetArea(double sideA, double sideB, double sideC) => new Triangle(sideA, sideB, sideC).GetArea();
        /// <summary>
        /// The method gets the circle area if the radius is known.
        /// </summary>
        /// <param name="radius">The radius.</param>
        /// <returns>System.Double.</returns>
        public static double GetArea(double radius) => new Circle(radius).GetArea();
        /// <summary>
        /// The method determines whether the triangle is rectangular.
        /// </summary>
        /// <param name="triangle">The Triangle object.</param>
        /// <returns><c>true</c> if is rectangular triangle, otherwise <c>false</c>.</returns>
        /// <exception cref="System.NullReferenceException"></exception>
        public static bool IsRectangularTriangle(Triangle triangle) =>
            (triangle != null) ? triangle.IsRectangular() : throw new NullReferenceException("the triangle must contain a reference to the object");
    }
}
