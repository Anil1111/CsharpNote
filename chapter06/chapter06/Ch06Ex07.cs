//using System;

//namespace chapter06
//{
//    class Ch06Ex07
//    {
//        delegate double DeleGateProcess(double para1, double para2);
//        static double Add_2(double para1, double para2) => para1 + para2;
//        static double Sub_2(double para1, double para2) => para1 - para2;
//        static double Mul_2(double para1, double para2) => para1 * para2;
//        static double Div_2(double para1, double para2) => para1 / para2;

//        static void Main(string[] args)
//        {
//            DeleGateProcess process = new DeleGateProcess(Add_2);
//            Console.WriteLine("Enter to number:");
//            double para1 = Convert.ToDouble(Console.ReadLine());
//            double para2 = Convert.ToDouble(Console.ReadLine());

//            Console.WriteLine("1) A->Add \n2) S->Sub \n3) M->mul \n4) D->div \n5) q->quit");

//            bool flag = true;
//            while(flag)
//            {
//                string command = Console.ReadLine();
//                switch(command)
//                {
//                    case "q": flag = false;break;
//                    case "A": process = Add_2;break;
//                    case "S": process = Sub_2;break;
//                    case "M": process = Mul_2;break;
//                    case "D": process = Div_2;break;
//                    default: break;
//                }
//                if (flag == false)
//                    continue;
//                else
//                    Console.WriteLine(process(para1, para2));
//            }

//            Console.ReadKey();
//        }
//    }
//}