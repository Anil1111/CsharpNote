//using System;

//namespace Book
//{
//    class Person:IComparable
//    {
//        public string name;
//        public int age;
//        public Person(string name, int age)
//        {
//            this.name = name;
//            this.age = age;
//        }
//        public int CompareTo(object obj)
//        {
//            Person p1 = (Person)obj;
//            if (this.age < p1.age) return - 1;
//            if (this.age > p1.age) return 1;
//            return 0;
//        }
//    }
//    class Ch15Ex03
//    {
//        static void Main()
//        {
//            Person[] per = new Person[3] { new Person("abc", 13), new Person("def", 2), new Person("asd", 11) };
//            Array.Sort(per);
//            for (int i = 0; i < 3; ++i)
//                Show(per[i]);

//            Console.ReadKey();
//        }

//        static void Show(Person p1)
//        {
//            Console.WriteLine("Person Info:\nName: {0}\nAge: {1}", p1.name, p1.age);
//        }
//    }
//}