using System;


namespace GeometricFigureFactoryLib
{
    /// <summary>
    /// Class Circle. This class cannot be inherited.
    /// Implements the <see cref="GeometricFigureFactoryLib.GeometricFigure" />
    /// </summary>
    /// <seealso cref="GeometricFigureFactoryLib.GeometricFigure" />
    public sealed class Circle : GeometricFigure
    {
        private double radius;
        private double Radius { 
            get => radius; 
            set => radius = (value > 0) ? value : throw new ArgumentException("To calculate the area of a circle, the radius must be greater than 0"); }
        /// <summary>
        /// Initializes a new instance of the <see cref="Circle"/> class.
        /// </summary>
        /// <param name="radius">Circle radius.</param>
        public Circle(double radius)
        {
            Radius = radius;
        }
        /// <summary>
        /// Gets the area Circle.
        /// </summary>
        public override double GetArea() => Math.PI * Math.Pow(Radius, 2);
    }
}
