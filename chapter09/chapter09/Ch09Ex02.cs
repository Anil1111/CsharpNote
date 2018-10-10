//using System;

//namespace chapter09
//{
//    class Mybase
//    {
//        public Mybase()
//        {
//            Console.WriteLine("这是一个父类无参的构造函数。");
//        }
//        public Mybase(int i)
//        {
//            Console.WriteLine($"这是一个父类有参的构造函数，参数是i={i}");
//        }
//    }

//    class MyDerived:Mybase
//    {
//        public MyDerived():this(5, 6)
//        {
//            Console.WriteLine("这是子类无参的构造函数。");
//        }
//        public MyDerived(int i, int j) : base(j)
//        {
//            Console.WriteLine($"这是一个子类有两个参数的构造函数，参数是i={i}");
//        }
//    }

//    class Ch09Ex02
//    {
//        static void Main(string[] args)
//        {
//            MyDerived myDerive = new MyDerived();

//            Console.ReadKey();
//        }
//    }
//}