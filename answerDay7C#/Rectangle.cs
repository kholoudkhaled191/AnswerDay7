using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace answerDay7C_
{
    internal class Rectangle : IShape
    {
        private double length;
         private double width;

        public Rectangle(double length, double width)
        {
            this.length = length;
            this.width = width;
        }

        public double Area
        {
            get { return length*width; }
        }

        public double Draw()
        {
            return (length + width) * 2;
        }
    }
}
