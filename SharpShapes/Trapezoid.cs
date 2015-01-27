using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SharpShapes
{
    public class Trapezoid : Quadralateral
    {
        public Trapezoid(int BottomWidth, int TopWidth, int Height, int BottomAngle, int TopAngle)
            : base(BottomWidth, TopWidth, Height, Height, BottomAngle, BottomAngle, TopAngle, TopAngle)
        {

        }
    }
}
