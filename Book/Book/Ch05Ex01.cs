//using System;

//namespace Book
//{
//    class MyClass
//    {
//        public int intVal = 20;
//    }
//    class Ch05Ex01
//    {
//        //引用类型做值参数和引用参数对比
//        static void changeValue(MyClass c1)
//        {
//            //此时相当于把实参c1的地址传给形参c1
//            //此时在栈区为c1另开辟了一个内存空间
//            c1.intVal = 50;
//            Console.WriteLine("c1.intVal = {0}", c1.intVal);
//            c1 = new MyClass();
//            //此时形参c1又指向了新的地址，和原来的地址切断联系
//            Console.WriteLine("new c1.intVal = {0}", c1.intVal);
//        }
//        //两个方法进行比较
//        static void changeValueRef(ref MyClass c1)
//        {
//            //此时相当于为c2起了一个别名叫c1
//            //在栈区没有为c1开辟空间，c1和c2共用栈区的空间，指向堆区的同一片内容。
//            c1.intVal = 50;
//            Console.WriteLine("c1.intVal = {0}", c1.intVal);
//            c1 = new MyClass();
//            Console.WriteLine("new c1.intVal = {0}", c1.intVal);
//        }

//        //输出参数
//        static void OutParas(out MyClass c1, out int intVal)
//        {
//            c1 = new MyClass();
//            c1.intVal = 22;
//            intVal = 30;
//        }


//        static void Main()
//        {
//            MyClass c1 = new MyClass();
//            Console.WriteLine("old c1.intVal = {0}", c1.intVal);
//            changeValue(c1);
//            Console.WriteLine("last c1.intVal = {0}", c1.intVal);

//            MyClass c2 = new MyClass();
//            Console.WriteLine("old c2.intVal = {0}", c2.intVal);
//            changeValueRef(ref c2);
//            Console.WriteLine("last c2.intVal = {0}", c2.intVal);

//            MyClass c3;
//            int intVal;
//            OutParas(out c3, out intVal);
//            Console.WriteLine("c3.intVal={0}", c3.intVal);
//            Console.WriteLine("intVal = {0}", intVal);

//            Console.ReadKey();
//        }
//    }
//}