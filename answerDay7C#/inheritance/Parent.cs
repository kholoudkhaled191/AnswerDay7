using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace answerDay7C_.inheritance
{
    internal class Parent
    {
        private int x;
        private int y;

        public int X
        {
            get { return x; }
            set { x = value; }
        }
        public int Y
        {
            get { return y; }
            set { y = value; }
        }



        //ctor
        public Parent(int _x, int _y)
        {
            this.x = _x;
            this.y = _y;
        }

        public virtual int Product()
        {
                return x * y;
        }

        public override string ToString()
        {
            return $"({x},{y})";
        }

    }
}
