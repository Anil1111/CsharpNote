//using System;

//namespace Book
//{
//    class Student
//    {
//        public int id;
//        public string name;
//        public Student() { id = 28; name = "Neno"; }
//        public Student(int val) { id = val; name = "Neno"; }
//        public Student(string name) { this.name = name; id = 28; }

//        public void SoundOff()
//        {
//            Console.WriteLine("Name {0}, Id {1}.", name, id);
//        }
//    }

//    class RandomNumberClass
//    {
//        private static Random RandomKey;
//        public static int m;

//        static RandomNumberClass()
//        {
//            RandomKey = new Random();
//            m = 12;
//        }

//        public int GetRandomNumber()
//        {
//            return RandomKey.Next();
//        }
        
//        public void ShowOff()
//        {
//            Console.WriteLine("static m = {0}", m);
//        }
//    }

//    class SubClass: RandomNumberClass
//    {
//        static SubClass()
//        {
//            m = 13;
//        }
//    }

//    class Point
//    {
//        public int X;
//        public int Y;
//        public Point(int X, int Y)
//        {
//            this.X = X;
//            this.Y = Y;
//        }
//        public Point()
//        {
//            this.X = 1;
//            this.Y = 2;
//        }
//    }

//    class Shape
//    {
//        readonly double PI = 3.1415926;
//        double pi
//        {
//            get
//            {
//                return this.PI;
//            }
//        }
//        public readonly int NumberOfSides;
//        public Shape(int side1)
//        {
//            NumberOfSides = side1;
//        }
//        public Shape()
//        {
//            NumberOfSides = 3;
//        }
//    }

//    class Ch06Ex03
//    {
//        static void Main(string[] args)
//        {
//            Student stu1 = new Student(),
//                    stu2 = new Student(7),
//                    stu3 = new Student("Bill");

//            stu1.SoundOff();
//            stu2.SoundOff();
//            stu3.SoundOff();

//            Console.WriteLine("+++++++++++++++++++++++++++++++++++");

//            RandomNumberClass a = new RandomNumberClass();
//            RandomNumberClass b = new RandomNumberClass();

//            Console.WriteLine("Next Random #:{0}", a.GetRandomNumber());
//            Console.WriteLine("Next Random #:{0}", b.GetRandomNumber());
//            a.ShowOff();
//            b.ShowOff();

//            // 此时直接用类调用静态构造函数，所以直接调用基类的静态构造函数
//            Console.WriteLine("m in RandomNumberClass = {0}", RandomNumberClass.m);
//            Console.WriteLine("m in SubClass = {0}", SubClass.m);
            

//            // 这种方式会先调用基类的静态构造函数，之后会调用子类的静态构造函数
//            // 每个类的静态构造函数只会被调用一次
//            SubClass c = new SubClass();
//            Console.WriteLine("m in RandomNumberClass = {0}", RandomNumberClass.m);
//            Console.WriteLine("m in SubClass = {0}", SubClass.m);

//            Console.WriteLine("+++++++++++++++++++++++++++++++++++");

//            Point pt1 = new Point(1, 2);
//            Point pt2 = new Point{ X = 5, Y = 6 };
//            Console.WriteLine($"pt1.x = {pt1.X}, pt1.Y = {pt1.Y}");
//            Console.WriteLine($"pt2.x = {pt2.X}, pt2.Y = {pt2.Y}");

//            Shape s1 = new Shape(12);
//            Console.WriteLine(s1.NumberOfSides);

//            Console.ReadKey();
//        }
//    }
//}