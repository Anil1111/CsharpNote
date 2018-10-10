//using System;

//namespace Book
//{
//    abstract class AbClass
//    {
//        public void IdentifyBase()
//        {
//            Console.WriteLine("I am Abclass.");
//        }
//        abstract public void IdentityDerived();
//    }

//    class DerivedClass:AbClass
//    {
//        public override void IdentityDerived()
//        {
//            Console.WriteLine("I am DerivedClass.");
//        }
//    }

//    abstract class MyBase
//    {
//        public int sideLength = 10;
//        const int triangleSideCount = 3;

//        abstract public void PrintStuff(string s);
//        abstract public int MyInt { get; set; }

//        public int PerimeterLength()
//        {
//            return triangleSideCount * sideLength;
//        }
//    }

//    class MyClass : MyBase
//    {
//        private int _myInt;
//        public override void PrintStuff(string s)
//        {
//            Console.WriteLine(s);
//        }
//        public override int MyInt
//        {
//            get
//            {
//                return _myInt;
//            }

//            set
//            {
//                _myInt = value;
//            }
//        }
//    }

//    sealed class LastClass:MyClass // 继承树的最低端，不可以再次被继承
//    {

//    }

//    //class TestClass:LastClass
//    //{
//    //    // “TestClass”: 无法从密封类型“LastClass”派生 Book
//    //}

//    static class MyMath
//    {
//        public static float PI = 3.14f;
//        public static bool IsOdd(int x)
//        {
//            return x % 2 == 1;
//        }
//        public static int Times2(int x)
//        {
//            return x * 2;
//        }
//    }

//    class Ch07Ex02
//    {
//        static void Main(string[] args)
//        {
//            DerivedClass b = new DerivedClass();
//            b.IdentifyBase();
//            b.IdentityDerived();

//            Console.WriteLine("*****************************");

//            MyClass mc = new MyClass();
//            mc.PrintStuff("This is a string.");
//            mc.MyInt = 28;
//            Console.WriteLine(mc.MyInt);
//            Console.WriteLine($"Perimeter Length: {mc.PerimeterLength()}.");

//            Console.WriteLine("*****************************");

//            int val = 3;
//            Console.WriteLine("{0} is odd is {1}", val, MyMath.IsOdd(val));
//            Console.WriteLine("{0} * 2 = {1}", val, MyMath.Times2(val));
//            Console.WriteLine("PI = {0}", MyMath.PI);
            
//            Console.ReadKey();
//        }
//    }
//}