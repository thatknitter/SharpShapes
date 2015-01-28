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

        public Square(int edgelength, int angle) : base(edgelength, edgelength, edgelength, edgelength, angle, angle, angle, angle)
        {
            this.edgelength = edgelength;
        }



    }
}

