//using System;

//namespace Book
//{
//    delegate int OtherDel(int InParam);
//    delegate void ShowArr(int c, params int[] d);
//    class Ch13Ex04
//    {
//        static void Main()
//        {
//            OtherDel oDel = delegate (int a)
//            {
//                return a + 20;
//            };

//            Console.WriteLine(oDel(12));
//            Console.WriteLine("*********************************");

//            ShowArr sa = delegate (int c, int[] d)
//            {
//                Console.WriteLine("c={0}", c);
//                for (int i = 0; i < d.Length; ++i)
//                    Console.WriteLine("d[{0}]={1}", i, d[i]);
//            };

//            sa(1, 2, 3, 4, 5, 6, 7);

//            Console.WriteLine("*********************************");

//            int b = 20;
//            {
//                Console.WriteLine(b);
//            }
//            Console.WriteLine(b);
//            Console.ReadKey();
//        }
//    }
//}