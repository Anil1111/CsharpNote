//using System;

//namespace chapter09
//{
//    class MyClass
//    {
//        public int val;
//    }

//    struct MyStruct
//    {
//        public int val;
//    }

//    class Ch09Ex03
//    {
//        static void Main(string[] args)
//        {
//                MyClass myClass = new MyClass();
//                myClass.val = 12;
//                Console.WriteLine($"myClass.val = {myClass.val}");
//                MyClass myClass1 = new MyClass();
//                myClass1 = myClass;
//                myClass1.val = 13;
//                Console.WriteLine($"myClass1.val = {myClass1.val}");
//                Console.WriteLine($"myClass.val = {myClass.val}");

//                MyStruct test = new MyStruct();
//                test.val = 15;
//                Console.WriteLine(test.val);
//                MyStruct test1 = test;
//                test1.val = 16;
//                Console.WriteLine(test.val);
//                Console.WriteLine(test1.val);

//                Console.ReadKey();
            

//        }
//    }
//}