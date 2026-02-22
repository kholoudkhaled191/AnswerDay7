using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace answerDay7C_
{
    internal class _ٌRectangle : Shape
    {
        public double height { get; set; }
        public double width { get; set; }

        public _ٌRectangle(double height, double width)
        {
            this.height = height;
            this.width = width;
        }

        public override void Draw()
        {
            Console.WriteLine("yes , A Rectangle is drawn");
        }

        public override double CalculateArea()
        {
            return height * width;
        }

    }
}
