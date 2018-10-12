//using System;

//namespace Book
//{
//    interface IShow
//    {
//        void Show();
//    }
//    class Person:IShow
//    {
//        public string name;
//        public int age;

//        public static implicit operator int(Person p1)
//        {
//            return p1.age;
//        }
//        void IShow.Show()
//        {
//            Console.WriteLine("this is in the class");
//        }
//    }

//    class Employ:Person
//    { }

//    class Ch16Ex03
//    {
//        static void Main()
//        {
//            Employ e = new Employ();
//            e.name = "johnson";
//            e.age = 23;
//            if(e is Person)
//            {
//                double age = e;
//                Console.WriteLine("Age = {0}", age);
//            }

//            Person p = e as Person;
//            if (p != null)
//                Console.WriteLine("Personal info:\nName:{0}\nAge:{1}", p.name, p.age);

//            IShow s = e as IShow;
//            s.Show();

//            Console.ReadKey();
//        }
//    }
//}