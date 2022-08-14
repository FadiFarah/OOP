using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Lesson_1.Polymorphism
{
    class PolySample
    {
        public void aaa()
        {
            Console.WriteLine("aaa");
            bbb(1, 2);
        }

        public virtual int bbb(int n1, int n2)
        {
            return n1 + n2;
        }
    }
}
