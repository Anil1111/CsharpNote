//using System;

//namespace Book
//{
//    class Person
//    {
//        public string name;
//        public int age;
//        //public Person(string name, int age)
//        //{
//        //    this.name = name;
//        //    this.age = age;
//        //}
//        public static implicit operator int(Person p)
//        {
//            return p.age;
//        }
//        //public static implicit operator Person(int age)
//        //{
//        //    return new Person("default", age);
//        //}
//        //public static explicit operator double(Person p)
//        //{
//        //    return p.age;
//        //}
//    }
//    class Employ:Person
//    { }
//    class Ch16Ex02
//    {
//        static void Main()
//        {
//            //Person p1 = new Person("zhushuai", 23);
//            //int age = p1 + 10;
//            //Console.WriteLine("Age = {0}", age);
//            //Person p2 = 12;

//            Employ e1 = new Employ();
//            e1.age = 12;
//            e1.name = "zhushuai";
//            //int iage = e1;
//            float fage = e1;
//            Console.WriteLine($"Name:{e1.name}\nAge:{fage}");

//            if (e1 is Person)
//                Console.WriteLine("True");

//            Console.ReadKey();
//        }
//    }
//}