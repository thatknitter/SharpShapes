using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SharpShapes
{
    abstract public class Quadralateral : Shape
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

        public decimal AddAngles()
        {
            throw new NotImplementedException();
        }

        public Quadralateral(int Bottomwidth, int Topwidth, int Leftheight, int Rightheight, int AngleA, int AngleB, int AngleC, int AngleD)
        {
            if (Bottomwidth <= 0 || Topwidth <= 0 || Leftheight <= 0 || Rightheight <= 0 || AngleA <= 0 || AngleB <= 0 || AngleC <= 0 || AngleD <= 0 )
            {
                throw new ArgumentException();
            }
            this.Bottomwidth = Bottomwidth;
            this.Topwidth = Topwidth;
            this.Leftheight = Leftheight;
            this.Rightheight = Rightheight;
        }

        public override void Scale(int percent)
        {
            if (percent <= 0)
            {
                throw new ArgumentException();
            }
            Bottomwidth = Bottomwidth * percent / 100;
            Topwidth = Topwidth * percent / 100;
            Leftheight = Leftheight * percent / 100;
            Rightheight = Rightheight * percent / 100;
        }

    }
}
