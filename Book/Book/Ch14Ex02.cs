//using System;

//namespace Book
//{
//    class CEO
//    {
//        public event EventHandler MessageSpread;
//        public void Orders()
//        {
//            for (int i = 0; i < 1e5; ++i)
//            {
//                if (i % 100 == 0 && MessageSpread != null)
//                    MessageSpread(this, null);
//            }
//        }

//    }
//    class SecOffice
//    {
//        public SecOffice(CEO c1)
//        {
//            c1.MessageSpread += Report;
//        }
//        void Report(object sender, EventArgs s)
//        {
//            Console.WriteLine("SecOffice got");
//        }
//    }
//    class HROffice
//    {
//        public HROffice(CEO c1)
//        {
//            c1.MessageSpread += Report;
//        }
//        void Report(object sender, EventArgs s)
//        {
//            Console.WriteLine("HROffice got");
//        }
//    }
//    class MarketingOffice
//    {
//        public MarketingOffice(CEO c1)
//        {
//            c1.MessageSpread += Report;
//        }
//        void Report(object sender, EventArgs s)
//        {
//            Console.WriteLine("MarketingOffice got");
//        }
//    }
//    class Ch14Ex02
//    {
//        static void Main()
//        {
//            CEO c1 = new CEO();
//            SecOffice so = new SecOffice(c1);
//            HROffice ho = new HROffice(c1);
//            MarketingOffice mo = new MarketingOffice(c1);

//            c1.Orders();

//            Console.ReadKey();
//        }
//    }
//}