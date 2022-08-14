using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Lesson_1
{
    class AccessModifiers
    {
        public string publicField;
        private string privateField;
        protected string protectedField;
        internal string internalField;

        public void publicMethod()
        {
            Console.WriteLine("Public method");
        }

        private void privateMethod()
        {
            Console.WriteLine("private method");
        }

        protected void protectedMethod()
        {
            Console.WriteLine("protected method");
        }

        internal void internalMethod()
        {
            Console.WriteLine("internal method ");
        }
    }
}
