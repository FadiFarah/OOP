using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Lesson_1.PolyProperties
{
    class PolyPropertiesDerived : PolyProperties
    {
        public override int MyInt
        {
            get { return 0; }
        }

        public override int bbb(int n1, int n2)
        {
            return n1 * n2;
        }
    }
}
