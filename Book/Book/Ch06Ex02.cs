//using System;

//namespace Book
//{
//    class C1
//    {
//        private int TheRealValue;
//        public int MyValue
//        {
//            set
//            {
//                TheRealValue = value;
//            }
//            get
//            {
//                return TheRealValue;
//            }
//        }
//    }

//    class RightTriangle
//    {
//        public double a;
//        public double b;
//        public RightTriangle(double a, double b)
//        {
//            this.a = a;
//            this.b = b;
//        }
//        public double Hypotenuse
//        {
//            get
//            {
//                return Math.Sqrt((a * a) + (b * b));
//            }
//        }
//        public int AutoProp
//        {
//            // get访问器会默认把属性值设为0
//            set;get;
//        }
//    }

//    class Smember
//    {
//        static private int TestVal;
//        public static int testVal
//        {
//            //静态属性只可以访问静态成员不可以对普通成员进行访问；
//            get
//            {
//                return TestVal;
//            }

//            set
//            {
//                TestVal = value;
//            }

//        }
//    }

//    class Trivial
//    {
//        public static int myValue { get; set; }

//        public void PrintValue()
//        {
//            Console.WriteLine("Value from inside:{0}", myValue);
//        }
//    }

//    class Ch06Ex02
//    {
//        static void Main(string[] args)
//        {
//            C1 A = new C1();
//            A.MyValue = 12;
//            int pri = A.MyValue;
//            Console.WriteLine(pri);

//            RightTriangle r1 = new RightTriangle(3, 4);
//            Console.WriteLine(r1.Hypotenuse);

//            Console.WriteLine(r1.AutoProp);
//            r1.AutoProp = 120;
//            Console.WriteLine(r1.AutoProp);

//            Smember.testVal = 12;
//            Console.WriteLine(Smember.testVal);

//            Console.WriteLine("*********************************");

//            Console.WriteLine("Init value:{0}", Trivial.myValue);
//            Trivial.myValue = 10;
//            Console.WriteLine("New Value:{0}", Trivial.myValue);
//            Trivial t1 = new Trivial();
//            t1.PrintValue();

//            Console.ReadKey();
//        }
//    }
//}