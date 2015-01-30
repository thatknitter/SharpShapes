using System.Drawing;
using System.Windows.Controls;

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

        /// <summary>
        /// Creates a polygon representing the shape and adds it to ShapeCanvas
        /// </summary>
        /// <param name="ShapeCanvas">The canvas on which to draw the shape</param>
        /// <param name="x"></param>
        /// <param name="y"></param>
        abstract public void DrawOnto(Canvas ShapeCanvas, int x, int y);
        
    }
}
