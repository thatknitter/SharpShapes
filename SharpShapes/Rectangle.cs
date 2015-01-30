using System;
using System.Windows;
using System.Windows.Media;

namespace SharpShapes
{
    public class Rectangle : Quadrilateral
    {
        private decimal width;
        public decimal Width
        {
            get { return this.width; }
        }

        private decimal height;
        public decimal Height
        {
            get { return this.height; }
        }

        public Rectangle(int width, int height)
        {
            if (width <= 0 || height <= 0)
            {
                throw new ArgumentException();
            }
            this.width = width;
            this.height = height;
        }

        public override decimal Area()
        {
            return Height * Width;
        }

        private void DrawRectangle()
        {
            System.Windows.Shapes.Polygon myPolygon = new System.Windows.Shapes.Polygon();
            myPolygon.Stroke = System.Windows.Media.Brushes.Tomato;
            myPolygon.Fill = System.Windows.Media.Brushes.Bisque;
            myPolygon.StrokeThickness = 2;
            myPolygon.HorizontalAlignment = HorizontalAlignment.Left;
            myPolygon.VerticalAlignment = VerticalAlignment.Center;
            Point point1 = new Point(10, 50);
            Point point2 = new Point(10, 80);
            Point point3 = new Point(50, 80);
            Point point4 = new Point(50, 50);

            PointCollection myPointCollection = new PointCollection();
            myPointCollection.Add(point1);
            myPointCollection.Add(point2);
            myPointCollection.Add(point3);
            myPointCollection.Add(point4);

            myPolygon.Points = myPointCollection;
            ShapeCanvas.Children.Add(myPolygon);
        }

        public override decimal Perimeter()
        {
            return 2 * Height + 2 * Width;
        }

        public override void Scale(int percent)
        {
            if (percent <= 0)
            {
                throw new ArgumentException();
            }
            this.width = width * percent / 100;
            this.height = height * percent / 100;
        }
    }
}