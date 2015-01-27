using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SharpShapes
{
    public class Quadralateral : Shape
    {
        private decimal Topwidth;
        public decimal TopWidth 
        {
            get { return this.Topwidth; } 
        }

        private decimal Bottomwidth;
        public decimal BottomWidth
        {
            get { return this.Bottomwidth; }
        }

        private decimal Leftheight;
        public decimal LeftHeight 
        {
            get { return this.Leftheight; } 
        }

        private decimal Rightheight;
        public decimal RightHeight
        {
            get { return this.Rightheight; }
        }

        public override int SidesCount
        {
            get { return 4; }
        }

        public override decimal Area()
        {
            return LeftHeight * BottomWidth;
        }

        public override decimal Perimeter()
        {
            return LeftHeight + RightHeight + BottomWidth + TopWidth;
        }

        public Quadralateral(int BottomWidth, int TopWidth, int LeftHeight, int RightHeight, int AngleA, int AngleB, int AngleC, int AngleD)
        {
            if (BottomWidth <= 0 || TopWidth <= 0 || LeftHeight <= 0 || RightHeight <= 0)
            {
                throw new ArgumentException();
            }
            this.Bottomwidth = BottomWidth;
            this.Topwidth = TopWidth;
            this.Leftheight = LeftHeight;
            this.Rightheight = RightHeight;
        }

        public override void Scale(int percent)
        {
            if (percent <= 0)
            {
                throw new ArgumentException();
            }
            Bottomwidth = BottomWidth * percent / 100;
            Topwidth = TopWidth * percent / 100;
            Leftheight = LeftHeight * percent / 100;
            Rightheight = RightHeight * percent / 100;
        }
    }
}
