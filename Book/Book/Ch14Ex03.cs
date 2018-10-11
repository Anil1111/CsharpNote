//using System;

//namespace Book
//{
//    class Pusher
//    {
//        public event EventHandler SimpleEvent;
//        public void Show()
//        {
//            SimpleEvent(this, null);
//        }
//    }

//    class Subscriber
//    {
//        public void MethodA(object o, EventArgs e) { Console.WriteLine("AAA"); }
//        public void MethodB(object o, EventArgs e) { Console.WriteLine("BBB"); }
//    }

//    class Ch14Ex03
//    {
//        static void Main()
//        {
//            Pusher p1 = new Pusher();
//            Subscriber s1 = new Subscriber();
//            p1.SimpleEvent += s1.MethodA;
//            p1.SimpleEvent += s1.MethodB;
//            p1.Show();

//            Console.WriteLine("Delete A Method!");
//            p1.SimpleEvent -= s1.MethodA;
//            p1.Show();

//            Console.ReadKey();
//        }
//    }
//}