//using System;

//namespace Book
//{
//    class MyClass
//    {
//        public static int a;
//        public int b;
//        //成员常量和静态成员也是只能通过类名来进行访问
//        //但是它在内存中没有存储位置
//        public const int c = 12;
//        static MyClass()
//        {
//            a = 12;
//        }
//        public MyClass(int b)
//        {
//            ++a;
//            this.b = b;
//        }
//        public void Display(string str)
//        {
//            Console.WriteLine($"{str}, a={a},b={b}");
//        }
//        public static void ValueAdd()
//        {
//            ++a;
//        }
//    }
//    class Ch06Ex01
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine(MyClass.a);
//            MyClass A = new MyClass(1);
//            A.Display("A");
//            MyClass.ValueAdd();
//            A.Display("A");
//            // 所有静态成员都需要用类名来进行访问
//            MyClass B = new MyClass(2);
//            B.Display("B");
//            MyClass C = new MyClass(3);
//            C.Display("C");

//            Console.WriteLine(MyClass.c);

//            const int IntVal1 = 100;
//            const int IntVal2 = IntVal1 * 2;

//            Console.ReadKey();
//        }
//    }
//}