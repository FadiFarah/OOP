using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Lesson_1
{
    class PropertySample
    {
        public string Text { get; set; }
        public int Number { get; set; }

        public void Test()
        {
            Console.WriteLine(Text + " " + Number);
        }
    }
}
