//using System;
//using System.Collections.Generic;
//using System.Linq;

//namespace Book
//{
//    class Student
//    {
//        public int StID;
//        public string LastName;
//    }
//    class CourseStudent
//    {
//        public string CourseName;
//        public int StID;
//    }
//    class Ch19Ex03
//    {
//        static void Main()
//        {
//            Student[] students = new Student[] {
//                                    new Student { StID = 1, LastName = "Carson"},
//                                    new Student { StID = 2, LastName = "Klassen"},
//                                    new Student { StID = 3, LastName = "Fleming"},};

//            CourseStudent[] studentsincourses = new CourseStudent[] {
//                                                                    new CourseStudent { CourseName = "Art", StID = 1},
//                                                                    new CourseStudent { CourseName = "Art", StID = 2},
//                                                                    new CourseStudent { CourseName = "History", StID = 1},
//                                                                    new CourseStudent { CourseName = "History", StID = 3},
//                                                                    new CourseStudent { CourseName = "Physics", StID = 3}};

//            var query = from s in students join c in studentsincourses on s.StID equals c.StID where c.CourseName == "History" select s.LastName;

//            foreach (var item in query)
//                Console.Write("{0}\t", item);
//            Console.WriteLine();
//            Console.WriteLine(students[0]);
//            Console.ReadKey();
//        }
//    }
//}