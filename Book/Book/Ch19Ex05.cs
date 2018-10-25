using System;
using System.Collections.Generic;
using System.Linq;

namespace Book
{
    class Ch19Ex05
    {
        static void Main()
        {
            var students = new[] {
                                new { name = "zhushuai", age = 24, sex = 'f', major = "control" },
                                new { name = "johnson", age = 22, sex = 'f', major = "histroy" },
                                new { name = "tomas", age = 18, sex = 'f', major = "art" },
                                new { name = "alice", age = 25, sex = 'm', major = "literature" },
                                new { name = "polly", age = 24, sex = 'm', major = "electronic" }
                                };

            var student = from stu in students
                          where stu.age > 20
                          orderby stu.age ascending
                          group stu by stu.age;
                          

            foreach (var item in student)
            {
                Console.WriteLine("{0}", item.Key);
                foreach (var obj in item)
                    Console.WriteLine("\t{0},{1},{2}", obj.name, obj.sex, obj.major);
            }
            Console.WriteLine("*********************************************");

            var student1 = from stu in students
                           select new { stu.name, stu.age };

            foreach (var item in student1)
                Console.WriteLine(item);

            Console.WriteLine("*********************************************");

            int[] GroupA = { 2, 3, 4, 5, 6 };
            int[] GroupB = { 3, 4, 5, 6, 7 };

            var numbers = from a in GroupA
                          join b in GroupB on a equals b into GroupAandB
                          from c in GroupAandB
                          select c;
            foreach (var item in numbers)
                Console.Write($"{item}\t");
            

            Console.ReadKey();
        }
    }
}