//using System;

//namespace Book
//{
//    class DaysTemp
//    {
//        public int High, Low;
//        public DaysTemp()
//        {
//            this.High = 0;
//            this.Low = 0;
//        }
//        public DaysTemp(int High, int Low)
//        {
//            this.High = High;
//            this.Low = Low;
//        }
//        public int average()
//        {
//            return (High + Low) / 2;
//        }
//    }
//    class Ch04Ex01
//    {
//        static void Main(string[] args)
//        {
//            DaysTemp t1 = new DaysTemp(76, 57);
//            DaysTemp t2 = new DaysTemp(75, 53);
//            //t1.High = 76;
//            //t1.Low = 57;
//            //t2.High = 75;
//            //t2.Low = 53;

//            Console.WriteLine("t1:{0},{1},{2}", t1.High, t1.Low, t1.average());
//            Console.WriteLine("t2:{0},{1},{2}", t2.High, t2.Low, t2.average());

//            //t2 = t1;
//            //t2.High = 12;
//            t2.High = t1.High;
//            t2.High = 12;
//            Console.WriteLine("t1:{0},{1},{2}", t1.High, t1.Low, t1.average());

//            int myInt=0;
//            for (int i=0;i<2;++i)
//            {
//                myInt = i;
//            }
//            Console.WriteLine(myInt);

//            Console.ReadKey();
//        }
//    }
//}