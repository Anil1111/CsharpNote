//using System;

//namespace chapter07
//{
//    class Ch07Ex04
//    {
//        static void Main(string[] args)
//        {
//            double para1 = Convert.ToDouble(Console.ReadLine());
//            double para2 = Convert.ToDouble(Console.ReadLine());
//            double result = 0;
//            try
//            {
//                result = para1 / para2;
//                // if (para2 == 0)
//                throw new DivideByZeroException();
//            }
//            catch (DivideByZeroException e)
//            {
//                Console.WriteLine(e.Message);
//            }

//            Console.ReadKey();
//        }
//    }
//}