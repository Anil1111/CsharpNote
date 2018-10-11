//using System;

//namespace Book
//{
//    //delegate void Handler();

//    class IncrementerEventArgs:EventArgs
//    {
//        public int IterationCount
//        {
//            get;
//            set;
//        }
//    }

//    class Incrementer
//    {
//        //public event Handler CountedADozen; //事件
//        public event EventHandler<IncrementerEventArgs> CountedADozen;

//        public void DoCount()
//        {
//            IncrementerEventArgs args = new IncrementerEventArgs();
//            for (int i = 1; i < 100; ++i)
//            {
//                if (i % 12 == 0 && CountedADozen != null)
//                {
//                    args.IterationCount = i;
//                    CountedADozen(this, args);
//                }
//            }
//        }
//    }

//    class Dozens
//    {
//        public int DozensCount { get; private set; }

//        public Dozens(Incrementer incremener)
//        {
//            DozensCount = 0;
//            incremener.CountedADozen += IncrementDozensCount;
//        }

//        void IncrementDozensCount(object sender, IncrementerEventArgs e)
//        {
//            Console.WriteLine("Incrementes at interation:{0} in {1}", e.IterationCount, sender.ToString());
//            DozensCount++;
//        }

//    }

//    class Ch13Ex01
//    {
//        static void Main()
//        {
//            Incrementer incremener = new Incrementer();
//            Dozens dozensCounter = new Dozens(incremener);
//            incremener.DoCount();

//            Console.WriteLine(dozensCounter.DozensCount);

//            Console.ReadKey();
//        }
//    }
//}