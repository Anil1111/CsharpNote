//using System;

//namespace Book
//{
//    delegate void Mydelegate<T>(T value);
//    delegate TR Func<T1, T2, TR>(T1 p1, T2 p2);

//    class Simple
//    {
//        static public void PrintString(string s)
//        {
//            Console.WriteLine(s);
//        }
//        static public void PrintUpperString(string s)
//        {
//            Console.WriteLine(s.ToUpper());
//        }
//        static public string PrintString(int p1, int p2)
//        {
//            int tmp = p1 + p2;
//            return tmp.ToString();
//        }
//    }
//    class Ch17Ex06
//    {
//        static void Main()
//        {
//            Mydelegate<string> md1 = new Mydelegate<string>(Simple.PrintString);
//            md1 += Simple.PrintUpperString;
//            md1("zhushuai");

//            Func<int, int, string> md2 = new Func<int, int, string>(Simple.PrintString);
//            string s1 = md2(3, 4);
//            Console.WriteLine(s1);

//            Console.ReadKey();
//        }
//    }
//}