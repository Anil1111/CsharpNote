//using System;

//namespace chapter05
//{
//    class Ch05Ex07
//    {
//        static void Main()
//        {
//            string myString = Console.ReadLine();
//            for (int i = myString.Length - 1; i >= 0; --i)
//                Console.Write(myString[i]);
//            Console.WriteLine();

//            Console.WriteLine("**************************************");

//            string mySentence = Console.ReadLine();
//            mySentence = mySentence.Replace("no", "yes");
//            Console.WriteLine(mySentence);

//            //mySentence = "\"" + mySentence.Replace(" ", "\" \"") + "\"";
//            //Console.WriteLine(mySentence);

//            string[] myWords;
//            myWords = mySentence.Split(' ');
//            foreach(string str in myWords)
//            {
//                Console.Write($"\"{str}\"");
//            }
//            Console.WriteLine();

//            Console.ReadKey();
//        }
//    }
//}