using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SharpShapes
{
    public class Square : Quadralateral
    {
        private decimal edgelength;
        public decimal edgeLength
        {
            get { return this.edgelength; }
        }

        public Square(int edgeLength, int angle) : base(edgeLength, edgeLength, edgeLength, edgeLength, angle, angle, angle, angle)
        {

        }

    }
}

