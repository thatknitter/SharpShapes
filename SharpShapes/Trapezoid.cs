using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SharpShapes
{
    public class Trapezoid : Quadralateral
    {
        private decimal height;
        public decimal Height
        {
            get { return this.height; }
        }

        private int Bottomangle;
        public int BottomAngle
        {
            get { return this.Bottomangle; }
        }

        private int Topangle;
        public int TopAngle
        {
            get { return this.Topangle; }
        }

        public Trapezoid(int BottomWidth, int TopWidth, int Height, int BottomAngle, int TopAngle)
            : base(BottomWidth, TopWidth, Height, Height, BottomAngle, BottomAngle, TopAngle, TopAngle)
        {

        }
    }
}
