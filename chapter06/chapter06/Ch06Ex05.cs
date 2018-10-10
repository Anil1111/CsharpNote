//using System;

//namespace chapter06
//{
//    class Ch06Ex05
//    {
//        delegate double ProcessDelegate(double para1, double para2);
//        static double Multiply(double para1, double para2) => para1 * para2;
//        static double Divide(double para1, double para2) => para1 / para2;

//        static void Main(string[] args)
//        {
//            ProcessDelegate process;
//            Console.WriteLine("Enter 2 numbers separated with a comma:");
//            string input = Console.ReadLine();
//            int commaPos = input.IndexOf(',');
//            double para1 = Convert.ToDouble(input.Substring(0, commaPos));
//            double para2 = Convert.ToDouble(input.Substring(commaPos + 1,
//                                            input.Length - commaPos - 1));
//            Console.WriteLine("Enter M to multiply or D to divide:");
//            input = Console.ReadLine();
//            if (input == "M")
//                //process = new ProcessDelegate(Multiply);
//                process = Multiply;
//            else
//                process = new ProcessDelegate(Divide);

//            Console.WriteLine($"Result: {process(para1, para2)}");

//            Console.ReadKey();

//        }
//    }
//}