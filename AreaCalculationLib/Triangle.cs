using System;


namespace GeometricFigureFactoryLib
{
    /// <summary>
    /// Class Triangle. This class cannot be inherited.
    /// Implements the <see cref="GeometricFigureFactoryLib.GeometricFigure" />
    /// </summary>
    /// <seealso cref="GeometricFigureFactoryLib.GeometricFigure" />
    public sealed class Triangle : GeometricFigure
    {
        private double sideA;
        private double sideB;
        private double sideC;
        private double SideA {
            get => sideA;
            set => sideA = (value > 0) ? value : throw new ArgumentException("Side A of the triangle must be greater than 0"); }
        private double SideB { 
            get => sideB;
            set => sideB = (value > 0) ? value : throw new ArgumentException("Side B of the triangle must be greater than 0"); }
        private double SideC { 
            get => sideC; 
            set => sideC = (value > 0) ? value : throw new ArgumentException("Side C of the triangle must be greater than 0"); }
        /// <summary>
        /// Initializes a new instance of the <see cref="Triangle"/> class.
        /// </summary>
        /// <param name="sideA">The side a.</param>
        /// <param name="sideB">The side b.</param>
        /// <param name="sideC">The side c.</param>
        public Triangle(double sideA, double sideB, double sideC)
        {
            SideA = sideA;
            SideB = sideB;
            SideC = sideC;
        }
        /// <summary>
        /// Get the area using the Heron formula
        /// </summary>
        public override double GetArea() {
            double halfPerimeter = (SideA + SideB + SideC) / 2;
            return Math.Sqrt(halfPerimeter * (halfPerimeter - SideA) * (halfPerimeter - SideB) * (halfPerimeter - SideC));
        }
        /// <summary>
        /// Checking if a triangle is rectangular.
        /// </summary>
        public bool IsRectangular() => (Math.Pow(SideA, 2) == Math.Pow(SideB, 2) + Math.Pow(SideC, 2)
                || Math.Pow(SideB, 2) == Math.Pow(SideA, 2) + Math.Pow(SideC, 2)
                || Math.Pow(SideC, 2) == Math.Pow(SideA, 2) + Math.Pow(SideB, 2)) ? true : false;

    }
}
