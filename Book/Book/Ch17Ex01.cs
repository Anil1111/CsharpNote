//using System;

//namespace Book
//{
//    class MyStack<T>
//    {
//        T[] StackArray = new T[MaxStack];
//        int stackPointer = 0;

//        public void Push(T x)
//        {
//            if (!IsStackFull)
//                StackArray[stackPointer++] = x;
//        }
        
//        public T pop()
//        {
//            return (!IsStackEmpty) ? StackArray[--stackPointer] : StackArray[0];
//        }
//        const int MaxStack = 10;
//        bool IsStackFull { get { return stackPointer >= MaxStack; } }
//        bool IsStackEmpty { get { return stackPointer <= 0; } }

//        //public MyStack()
//        //{
//        //    T[] StackArray = new T[MaxStack];
//        //}

//        public void Print()
//        {
//            int tmp = stackPointer;
//            for (int i = 0; i < tmp; ++i)
//                Console.WriteLine($"     value:{pop()}");
//        }
//    }
//    class Ch17Ex01
//    {
//        static void Main()
//        {
//            MyStack<int> StackInt = new MyStack<int>();
//            var StackString = new MyStack<string>();

//            StackInt.Push(3);
//            StackInt.Push(5);
//            StackInt.Push(7);
//            StackInt.Push(9);
//            StackInt.Print();

//            StackString.Push("This is fun");
//            StackString.Push("Hi there! ");
//            StackString.Print();

//            Console.ReadKey();
//        }
//    }
//}