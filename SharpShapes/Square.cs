
using System.Windows;
using System.Windows.Media;
namespace SharpShapes
{
    public class Square : Rectangle
    {
        public Square(int edgeLength)
            : base(edgeLength, edgeLength)
        {
        }

        private void DrawSquare(int x, int y, Square square)
        {
            System.Windows.Shapes.Polygon myPolygon = new System.Windows.Shapes.Polygon();

            SolidColorBrush border = new SolidColorBrush();
            border.Color = Color.FromArgb(square.BorderColor.A, square.BorderColor.R, square.BorderColor.G, square.BorderColor.B);

            SolidColorBrush fill = new SolidColorBrush();
            fill.Color = Color.FromArgb(square.FillColor.A, square.FillColor.R, square.FillColor.G, square.FillColor.B);

            myPolygon.Stroke = border;
            myPolygon.Fill = fill;
            myPolygon.StrokeThickness = 2;
            myPolygon.HorizontalAlignment = HorizontalAlignment.Left;
            myPolygon.VerticalAlignment = VerticalAlignment.Center;
            Point point1 = new Point(x, y);
            Point point2 = new Point(x, y + (double)square.Width);
            Point point3 = new Point(x + (double)square.Width, y + (double)square.Width);
            Point point4 = new Point(x + (double)square.Width, y);

            PointCollection myPointCollection = new PointCollection();
            myPointCollection.Add(point1);
            myPointCollection.Add(point2);
            myPointCollection.Add(point3);
            myPointCollection.Add(point4);

            myPolygon.Points = myPointCollection;
            ShapeCanvas.Children.Add(myPolygon);
        }
    }
}