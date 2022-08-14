using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Lesson_1.Interfaces
{
    class InterfaceSample : IInterfaceSample
    {
        public void test1(string txt)
        {
            Console.WriteLine(txt);
        }

        public void test2(string txt1, string txt2)
        {
            Console.WriteLine(txt1 + " " + txt2);
        }

        public void test3(string txt1, string txt2, string txt3)
        {
            Console.WriteLine(txt1 + " " + txt2 + " " + txt3);
        }
    }
}
