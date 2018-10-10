//using System;

///*
// * 数组的length属性
// * 对于一维数组和矩形数组获取的是整个数组的长度
// * 对于锯齿数组获得是相应层级的长度
// * 也就是说length对于数组获得的是变量第一层引用的长度
// */

//namespace Book
//{
//    class MyClass
//    {
//        public int a;
//        public int b;
//        public MyClass(int a, int b)
//        {
//            this.a = a;
//            this.b = b;
//        }
//    }
//    class Ch12Ex01
//    {
//        static void Main()
//        {
//            int[][] Jarray;
//            Jarray = new int[3][];
//            Jarray[0] = new int[1] { 1 };
//            Jarray[1] = new int[2] { 1, 2 };
//            Jarray[2] = new int[3] { 1, 2, 3 };

//            for (int i=0;i<Jarray.GetLength(0); ++i)
//            {
//                for (int j = 0; j < Jarray[i].GetLength(0); ++j)
//                    Console.WriteLine($"Jarray[{i}][{j}]={Jarray[i][j]}");
//            }
//            // 上述代码等价于
//            for (int i = 0; i < Jarray.Length; ++i)
//            {
//                for (int j = 0; j < Jarray[i].Length; ++j)
//                    Console.WriteLine($"Jarray[{i}][{j}]={Jarray[i][j]}");
//            }
//            Console.WriteLine("***************************************");
//            Console.WriteLine(Jarray[1].Length);
//            Console.WriteLine("***************************************");

//            foreach(int[] array in Jarray)
//            {
//                foreach (int i in array)
//                    Console.WriteLine(i);
//            }
//            Console.WriteLine("***************************************");

//            int[,] Rarray = { { 1, 2 }, { 3, 4 }, { 5, 6 } };
//            Console.WriteLine(Rarray.Length);

//            foreach (int a in Rarray)
//            {
//                Console.WriteLine(a);
//            }

//            Console.WriteLine("***************************************");

//            MyClass[] classArray = new MyClass[3] { new MyClass(1, 2), new MyClass(3, 4), new MyClass(5, 6) };
//            foreach(MyClass tmpVal in classArray)
//            {
//                Console.WriteLine(++tmpVal.a);
//            }

//            Console.ReadKey();
//        }
//    }
//}