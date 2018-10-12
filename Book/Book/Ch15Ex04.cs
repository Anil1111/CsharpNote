using System;

namespace Book
{
    interface IIfc1
    {
        void PrintOut(string s);
    }

    class MyClass:IIfc1
    {
        public void PrintOut(string s)
        {
            Console.WriteLine("Calling through: {0}", s);
        }
    }
    class Ch15Ex03
    {
        static void Main()
        {
            MyClass mc = new MyClass();
            mc.PrintOut("object");

            Console.ReadKey();
        }
    }
}