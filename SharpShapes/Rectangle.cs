using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SharpShapes
{
    public class Rectangle : Quadralateral
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

        public override int SidesCount
        {
            get { return 4; }
        }

        public override decimal Area()
        {
            return Height * Width;
        }

        public override decimal Perimeter()
        {
            return 2 * Height + 2 * Width;
        }

        public Rectangle(int width, int height, int angle) : base (width, width, height, height, angle, angle, angle, angle)
        {
            if (width <= 0 || height <= 0)
            {
                throw new ArgumentException();
            }
            this.width = width;
            this.height = height;
        }

        public override void Scale(int percent)
        {
            if (percent <= 0)
            {
                throw new ArgumentException();
            }
            width = width * percent / 100;
            height = height * percent / 100;
        }
    }
}
