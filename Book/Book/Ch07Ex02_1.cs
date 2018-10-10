//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace BookDerived
//{
//    class MyClass
//    {
//        readonly int firstVal;
//        readonly double secondVar;

//        public string userName;
//        public int userIDNumber;

//        private MyClass()
//        {
//            firstVal = 20;
//            secondVar = 30.5;
//        }

//        public MyClass(string firstName) : this()
//        {
//            userIDNumber = -1;
//            userName = firstName;
//        }

//        public MyClass(int idNumber) : this()
//        {
//            userName = "Anonymous";
//            userIDNumber = idNumber;
//        }

//        public void Show()
//        {
//            Console.WriteLine($"firstVal={firstVal}, secondval={secondVar}\nusername={userName}, useridnumber={userIDNumber}");
//        }

//    }
//}
