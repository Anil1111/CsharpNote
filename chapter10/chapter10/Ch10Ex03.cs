//using System;

//namespace chapter10
//{
//    public class ClassA
//    {
//        private int state = -1;
//        public int State
//        {
//            get
//            {
//                return state;
//            }
//            set
//            {
//                state = value;
//            }
//        }
//        public void Show()
//        {
//            Console.WriteLine($"state = {state}");
//        }
//        //public class ClassB
//        //{
//        //    public void SetPrivateState(ClassA target, int newState)
//        //    {
//        //        target.state = newState;
//        //    }
//        //}
//    }

//    class Ch10Ex03
//    {
//        static void Main()
//        {
//            ClassA myObject = new ClassA();
//            Console.WriteLine($"myObject.State = {myObject.State}");
//            myObject.State = 12;
//            myObject.Show();
//            //ClassA.ClassB myOtherObject = new ClassA.ClassB();
//            //myOtherObject.SetPrivateState(myObject, 999);
//            //Console.WriteLine($"myobject.State = {myObject.State}");

//            Console.ReadKey();
//        }
//    }
//}