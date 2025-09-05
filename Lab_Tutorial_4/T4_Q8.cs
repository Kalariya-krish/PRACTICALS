using System;

namespace PRACTICALS.Lab_Tutorial_4
{
    class X
    {
        public virtual void F() { Console.WriteLine("X.F"); }
        public virtual void F2() { Console.WriteLine("X.F2"); }
    }

    class Y : X
    {
        sealed public override void F() { Console.WriteLine("Y.F"); }
        public override void F2() { Console.WriteLine("Y.F2"); }
    }

    class Z : Y
    {
        public override void F2() { Console.WriteLine("Z.F2"); }
    }

    internal class T4_Q8
    {
        static void Main()
        {
            Console.WriteLine("Name : KALARIYA KRIS \nEnrollment No: 24SOECE13028\n");

            X Obj1 = new X();
            Obj1.F();
            Obj1.F2();

            Y Obj2 = new Y();
            Obj2.F();
            Obj2.F2();

            Z Obj3 = new Z();
            Obj3.F2();

            Console.Read();
        }
    }
}
