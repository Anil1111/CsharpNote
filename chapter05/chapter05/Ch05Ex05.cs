//using System;

//namespace chapter05
//{
//    class Ch05Ex05
//    {
//        static void Main()
//        {
//            string str = "A string";
//            char myChar = str[0];
//            Console.WriteLine(myChar);

//            char[] myChars = str.ToCharArray();
//            foreach (char ch in myChars)
//                Console.Write($"{ch}");
//            Console.WriteLine();

//            Console.WriteLine(myChars.Length);

//            Console.WriteLine("++++++++++++++++++++++++++++++++");

//            char[] trimChars = new char[3] { ' ', 'e', 's' };
//            string userResponse = Console.ReadLine();
//            userResponse = userResponse.Trim(trimChars);
//            if(userResponse == "y")
//            {
//                Console.WriteLine("yes");
//            }
//            else
//            {
//                Console.WriteLine("error");
//            }

//            string myString = "Aligned";
//            Console.WriteLine(myString.PadLeft(10, '-'));

//            Console.ReadKey();
//        }
//    }
//}