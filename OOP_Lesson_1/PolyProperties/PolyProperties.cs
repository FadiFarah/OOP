using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Lesson_1.PolyProperties
{
    class PolyProperties
    {
        public virtual int MyInt { get; set; } = 0;

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
