using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace SharpShapes
{
    abstract public class Shape
    {
        //Width, Height, Perimeter, Area
        /// <summary>
        /// Specifies the interior color of the shape
        /// </summary>
        public Color FillColor { get; set; }

        /// <summary>
        /// Specifies the color of the border of the shape, when drawn
        /// </summary>
        public Color BorderColor { get; set; }

        /// <summary>
        /// The number of sides in the shape
        /// </summary>
        abstract public int SidesCount { get; }

        public Shape()
        {
            BorderColor = Color.Tomato;
            FillColor = Color.Bisque;
        }

        
        /// <summary>
        /// Calculates the area of the shape
        /// </summary>
        /// <returns>Returns the area of this shape</returns>
        public abstract decimal Area();
        
        
        //Returns the perimeter of this shape
        /// <summary>
        /// Calculates the perimeter of the shape
        /// </summary>
        /// <returns>The perimeter</returns>
        abstract public decimal Perimeter();
        

        //Resizes a shape by percent%
        /// <summary>
        /// Scales the shape in size
        /// </summary>
        /// <param name="percent">The percentage by which to scale the shape</param>
        abstract public void Scale(int percent);
        
    }
}
