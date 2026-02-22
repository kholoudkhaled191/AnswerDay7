using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace answerDay7C_
{
    internal class File : IReadable, IWritable
    {
        public void Read()
        {
            Console.WriteLine("readable");
        }

        public void Write()
        {
            Console.WriteLine("writable");
        }
    }
}
