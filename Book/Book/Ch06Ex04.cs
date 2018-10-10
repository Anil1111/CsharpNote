//using System;

//namespace Book
//{
//    class Employee
//    {
//        public string lastName;
//        public string firstName;
//        public string cityOfBirth;

//        public string this[int index]
//        {
//            set
//            {
//                switch(index)
//                {
//                    case 0: lastName = value; break;
//                    case 1: firstName = value; break;
//                    case 2: cityOfBirth = value; break;
//                    default: throw new ArgumentOutOfRangeException("index");
//                }
//            }
//            get
//            {
//                switch(index)
//                {
//                    case 0:return lastName;
//                    case 1:return firstName;
//                    case 2:return cityOfBirth;
//                    default: throw new ArgumentOutOfRangeException("index");
//                }
//            }
//        }
//    }

//    class Person
//    {
//        public string name
//        {
//            private set;
//            get;
//        }
//        public Person(string name)
//        {
//            this.name = name;
//        }
//    }

//    class Numbers
//    {
//        private int tmp1;
//        private int tmp2;
//        public int this[int index]
//        {
//            get
//            {
//                return index == 0 ? tmp1 : tmp2;
//            }
//            set
//            {
//                if (index == 0)
//                    tmp1 = value;
//                else
//                    tmp2 = value;
//            }
//        }
//    }

//    class Ch06Ex04
//    {
//        static void Main(string[] args)
//        {
//            Employee e1 = new Employee();
//            e1[0] = "zhushuai";
//            e1[1] = "johnson";
//            e1[2] = "tomas";
//            Console.WriteLine($"lastName={e1[0]}");
//            Console.WriteLine($"firstName={e1[1]}");
//            Console.WriteLine($"cityOfBirth={e1[2]}");
//            try
//            {
//                Console.WriteLine($"cityOfBirth={e1[3]}");
//            }
//            catch(ArgumentOutOfRangeException e)
//            {
//                Console.WriteLine(e.Message);
//            }

//            Numbers n1 = new Numbers();
//            Console.WriteLine($"Old Values -- tmp1:{n1[0]}, tmp2:{n1[1]}");
//            n1[0] = 12;
//            n1[1] = 13;
//            Console.WriteLine($"New Values -- tmp1:{n1[0]}, tmp2:{n1[1]}");

//            Person p1 = new Person("zhushuai");
//            Console.WriteLine($"name:{p1.name}");

//            Console.ReadKey();
//        }
//    }
//}