//using System;

//namespace Book
//{
//    delegate int MyDel(int x);
//    delegate int MyDel2(int x, int y);
//    delegate int MyDel3(ref int x, out int y);
//    delegate int MyDel4();
//    class Ch13Ex05
//    {
//        static void Main()
//        {
//            MyDel mDel = x => x + 1;
//            Console.WriteLine(mDel(5));

//            MyDel2 mDel2 = (x, y) => x + y;
//            Console.WriteLine(mDel2(1, 2));

//            int a = 2;
//            int b = 3;
//            MyDel3 mDel3 = (ref int x, out int y) => { y = a; return x + y; };
//            Console.WriteLine(mDel3(ref a, out b));
//            Console.WriteLine("a={0}, b={1}", a, b);

//            MyDel4 mDel4 = () => 1;
//            Console.WriteLine(mDel4());

//            Console.ReadKey();
//        }
//    }
//}