using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace answerDay7C_.inheritance
{
    internal class Child :Parent
    {

        private int z;

        public int Z
        {
            get { return z; }
            set { z = value; }
        }

        public Child(int _x, int _y , int _z):base(_x, _y)
        {
            int z = _z;
            //Console.WriteLine($"({_x},{_y},{_z})");

           
        }
        //public new int Product()
        //{
        //    return X * Y * z;
        //}

        public override int Product()
        {
            return X * Y *z;
        }

        public override string ToString()
        {
            return $"({X}, {Y}, {Z})";
        }




    }
}
