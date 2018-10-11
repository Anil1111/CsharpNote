//using System;

//namespace Book
//{

//    delegate void MyDele(int a);
//    delegate void Operating(int a, int b);
//    delegate void ShowClass();

//    class MyClass
//    {
//        public void Print()
//        {
//            Console.WriteLine("This is a normal function in class.");
//        }
//        public static void Prints()
//        {
//            Console.WriteLine("This is a static function in class.");
//        }
//    }
//    class Ch13Ex01
//    {
//        static void Main()
//        {
//            MyDele myDele;

//            Random random = new Random();
//            int randomValue = random.Next(99);
//            myDele = randomValue > 50 ? new MyDele(ShowBigNumber) : new MyDele(ShowSmallNumber);

//            myDele(randomValue);

//            Console.WriteLine("******************************");
//            Operating op = new Operating(Add_2);
//            op += Sub_2;
//            op += Mul_2;
//            op += Div_2;

//            op(12, 2);

//            Console.WriteLine("******************************");

//            MyClass c = new MyClass();
//            ShowClass sc = new ShowClass(c.Print);
//            sc();
//            Console.WriteLine("******************************");

//            sc += MyClass.Prints;
//            sc();
//            Console.WriteLine("******************************");

//            Operating op1, op2, op3;
//            op1 = new Operating(Add_2);
//            op2 = new Operating(Sub_2);
//            op3 = op1 + op2;

//            op1(12, 2);
//            op2(10, 2);
//            op3(1, 2);

//            Console.ReadKey();
//        }



//        static void ShowBigNumber(int a)
//        {
//            Console.WriteLine("The big number is {0}", a);
//        }
//        static void ShowSmallNumber(int a)
//        {
//            Console.WriteLine("The small number is {0}", a);
//        }
//        static void Add_2(int a, int b)
//        {
//            Console.WriteLine($"{a}+{b}={a + b}");
//        }
//        static void Sub_2(int a, int b)
//        {
//            Console.WriteLine($"{a}-{b}={a - b}");
//        }
//        static void Mul_2(int a, int b)
//        {
//            Console.WriteLine($"{a}*{b}={a * b}");
//        }
//        static void Div_2(int a, int b)
//        {
//            Console.WriteLine($"{a}/{b}={a / b}");
//        }
//    }
//}