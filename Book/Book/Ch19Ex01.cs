//using System;
//using System.Collections.Generic;
//using System.Linq;

//namespace Book
//{
//    class Others
//    {
//        public static string Name = "Tomas Herry";
//    }
//    class Ch19Ex01
//    {
//        static void Main()
//        {
//            int[] numbers = { 2, 12, 5, 15 };
//            IEnumerable<int> lowNums = from n in numbers where n < 10 select n;
//            foreach (int var in lowNums)
//                Console.Write($"{var}   ");
//            Console.WriteLine();

//            Console.WriteLine("************************************");

//            var student = new { Name = "Mary Jones", Age = 19, Major = "History" };

//            Console.WriteLine("{0},Age:{1},Major:{2};", student.Name, student.Age, student.Major);

//            Console.WriteLine("************************************");

//            string occu = "Student";
//            var person = new { Age = 12, Others.Name, occu };
//            Console.WriteLine("{0},Age:{1},Major:{2};", person.Name, person.Age, person.occu);

//            int Age = 19;
//            string Major = "History";
//            var student1 = new { Name = Others.Name, Age = Age, Major = Major };
//            Console.WriteLine("{0},Age:{1},Major:{2};", student1.Name, student1.Age, student1.Major);
//            /*
//             *等价于:
//             * class Student
//             * {
//             *      public string Name;
//             *      public int Age;
//             *      public string Major;
//             *      public Student(Name, Age, Major)
//             *      {   
//             *          this.Name = Name;
//             *          this.Age = Age;
//             *          this.Major = Major;
//             *      }
//             * } 
//             */


//            Console.ReadKey();
//        }
//    }
//}