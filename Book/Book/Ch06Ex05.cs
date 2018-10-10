//using System;

//namespace Book
//{
//    partial class Student
//    {
//        public Student(string name, int age)
//        {
//            this.name = name;
//            this.age = age;
//        }
//        partial void ShowInfo()
//        {
//            Console.WriteLine($"name: {name}, age:{Convert.ToString(age)}");
//        }
//        public void Display()
//        {
//            ShowInfo();
//        }
//    }

//    class Ch06Ex05
//    {
//        static void Main(string[] args)
//        {
//            Student s1 = new Student("zhushuai", 24);
//            s1.Display();

//            Console.WriteLine("Press AnyKey to Stop...");
//            Console.ReadKey();
//        }
//    }
//}