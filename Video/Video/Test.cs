//using System;
//using System.Collections.Generic;

//namespace Video
//{
//    interface IFlyable
//    {
//        void Fly();
//    }
//    class Bird : IFlyable
//    {
//        public void Fly()
//        {
//            Console.WriteLine("A Bird Can Fly");
//        }
//    }
//    class Plane : IFlyable
//    {
//        public void Fly()
//        {
//            Console.WriteLine("A Plane Can Fly");
//        }
//    }
//    class Test
//    {
//        static void WhoCanFly(IFlyable list)
//        {
//            foreach (var item in list)
//                item.Fly();
//            list.Fly();
//        }
//        static void Main()
//        {
//            Bird B1 = new Bird();
//            Bird B2 = new Bird();
//            Bird B3 = new Bird();

//            Plane P1 = new Plane();
//            Plane P2 = new Plane();
//            Plane P3 = new Plane();

//            List<IFlyable> list = new List<IFlyable>();
//            list.Add(B1);
//            list.Add(B2);
//            list.Add(B3);

//            list.Add(P1);
//            list.Add(P2);
//            list.Add(P3);

//            WhoCanFly(list);
//            WhoCanFly(B1);

//            Console.ReadKey();

//        }
//    }
//}