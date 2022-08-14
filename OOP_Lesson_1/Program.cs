using OOP_Lesson_1.Inheritance;
using OOP_Lesson_1.Interfaces;
using OOP_Lesson_1.Polymorphism;
using System;

namespace OOP_Lesson_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Vehicle myCar = new Vehicle("NEXA", "TOTA", 4, 4);

            PropertySample p = new PropertySample();
            Console.WriteLine(p.Text);
            Console.WriteLine(p.Number);
            p.Test();

            InheritenceSample inheritBase = new InheritenceSample();
            DerivedClass inheritDerived = new DerivedClass();
            inheritBase.Test1();
            inheritBase.Test2();
            inheritDerived.Test1();
            inheritDerived.Test2();
            inheritDerived.Test3();
            inheritDerived.Test4();

            PolySample polyBase = new PolySample();
            PolyDerived polyDerived = new PolyDerived();

            polyBase.aaa();
            polyDerived.aaa();

            InterfaceSample interfaceSample = new InterfaceSample();
            interfaceSample.test1("Hello");
            interfaceSample.test2("Hello", "World");
            interfaceSample.test3("Hello", "Good", "People");

        }
    }
}
