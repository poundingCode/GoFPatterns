// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ShapeObjectFactory.cs"  company="James Fleming">
//   poundingCode@gmail.com
// </copyright>
// <summary>
//   The 'FlyweightFactory' class
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace PatternsTutorial.Behavioral.Flyweight.Example
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The 'FlyweightFactory' class
    /// </summary>
    internal class ShapeObjectFactory
    {
        /// <summary>
        /// The shapes
        /// </summary>
        private readonly Dictionary<string, IShape> shapes = new Dictionary<string, IShape>();

        /// <summary>
        /// Gets the total objects created.
        /// </summary>
        /// <value>The total objects created.</value>
        public int TotalObjectsCreated
        {
            get { return this.shapes.Count; }
        }

        /// <summary>
        /// Gets the shape.
        /// </summary>
        /// <param name="shapeName">
        /// Name of the shape.
        /// </param>
        /// <returns>
        /// I Shape.
        /// </returns>
        /// <exception cref="System.Exception">
        /// Factory cannot create the object specified
        /// </exception>
        public IShape GetShape(string shapeName)
        {
            IShape shape;
            if (this.shapes.ContainsKey(shapeName))
            {
                shape = this.shapes[shapeName];
            }
            else
            {
                switch (shapeName)
                {
                    case "Rectangle":
                        shape = new Rectangle();
                        this.shapes.Add("Rectangle", shape);
                        break;
                    case "Circle":
                        shape = new Circle();
                        this.shapes.Add("Circle", shape);
                        break;
                    default:
                        throw new Exception("Factory cannot create the object specified");
                }
            }

            return shape;
        }
    }
}