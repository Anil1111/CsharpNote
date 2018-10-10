//using System;

//namespace Book
//{
//    class Ch05Ex02
//    {

//        // 参数数组
//        static void parasfunc(params int[] intVals)
//        {
//            if(intVals.Length == 0)     
//                Console.WriteLine("Error");
//            else
//            {
//                for (int i = 0; i < intVals.Length; ++i)
//                    Console.Write($"{intVals[i] *= 10} ");
//                Console.WriteLine();
//            }
//        }

//        // 函数重载
//        static int Add_2(int a, int b)
//        {
//            return a + b;
//        }
//        static double Add_2(double a, double b)
//        {
//            return a + b;
//        }
//        static int Add_2(ref int a, int b)
//        {
//            a += 1;
//            return a + b;
//        }

//        // 命名参数
//        static void ArrayAddInt(int[] intVals, int myVal)
//        {
//            for (int i = 0; i < intVals.Length; ++i)
//                intVals[i] += myVal;
//        }

//        // 可选参数
//        static void MulDig(int row=9)
//        {
//            for (int i = 1; i <= row; ++i) 
//            {
//                for (int j = 1; j <= i; ++j)
//                    Console.Write($"{i}*{j}={i * j} ");
//                Console.WriteLine();
//            }
//        }

//        // 递归求阶乘
//        static int Fab(int myVal)
//        {
//            if (myVal <= 0)
//                return 0;
//            else
//            {
//                if (myVal == 1)
//                    return 1;
//                else
//                    return Fab(myVal - 1) * myVal;
//            }
//        }

//        static void Main(string[] args)
//        {
//            int[] intVals = new int[] { 1, 2, 3, 4, 5 };
//            int first = 1, sec = 2, thi = 3, forth = 4, fif = 5;
//            parasfunc(intVals);
//            for (int i = 0; i < intVals.Length; ++i)
//                Console.Write($"{intVals[i] } ");
//            Console.WriteLine();

//            Console.WriteLine("************************");
//            parasfunc(first, sec, thi, forth, fif);
//            Console.WriteLine($"{first}  {sec}  {thi}  {forth}  {fif}");

//            Console.WriteLine();
//            Console.WriteLine();
//            Console.WriteLine();

//            Console.WriteLine("Add_2(int, int)={0}", Add_2(first, sec));
//            Console.WriteLine("Add_2(double, double)={0}", Add_2(1.1, 2.2));
//            Console.WriteLine("Add_2(ref int, int)={0}, ref = {1}", Add_2(ref first, sec), first);

//            Console.WriteLine();
//            Console.WriteLine();
//            Console.WriteLine();

//            int[] intVals2 = new int[] { 1, 2, 3, 4, 5 };
//            int myVals = 1;
//            ArrayAddInt(myVal: myVals, intVals: intVals2);
//            for (int i = 0; i < intVals2.Length; ++i)
//                Console.Write($"{intVals2[i]} ");
//            Console.WriteLine();

//            Console.WriteLine();
//            Console.WriteLine();
//            Console.WriteLine();

//            MulDig();

//            Console.WriteLine();
//            Console.WriteLine();
//            Console.WriteLine();

//            MulDig(6);

//            Console.WriteLine();
//            Console.WriteLine();
//            Console.WriteLine();

//            Console.Write(Fab(10));

//            Console.ReadKey();
//        }
//    }
//}