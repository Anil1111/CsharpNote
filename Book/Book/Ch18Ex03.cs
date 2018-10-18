//using System;
//using System.Collections;

//namespace Book
//{
//    class Intenumerator:IEnumerator
//    {
//        int[] arr;
//        int _position = -1;
//        public Intenumerator(int[] arr)
//        {
//            this.arr = new int[arr.Length];
//            for (int i = 0; i < arr.Length; ++i)
//                this.arr[i] = arr[i];
//        }
//        public void Reset()
//        {
//            _position = -1;
//        }
//        public bool MoveNext()
//        {
//            if (_position < arr.Length - 1) 
//            {
//                _position++;
//                return true;
//            }
//            else
//                return false;
//        }
//        public object Current
//        {
//            get
//            {
//                if (_position == -1)
//                    return new InvalidOperationException();
//                if (_position >=arr.Length)
//                    return new InvalidOperationException();
//                return arr[_position];
//            }
//        }
//    }
//    class IntArray:IEnumerable
//    {
//        int[] arr;
//        public IntArray(int[] arr1)
//        {
//            arr = new int[arr1.Length];
//            for (int i = 0; i < arr1.Length; ++i)
//                this.arr[i] = arr1[i];
//        }
//        public IEnumerator GetEnumerator()
//        {
//            return new Intenumerator(arr);
//        }
//    }
//    class Ch18Ex03
//    {
//        static void Main()
//        {
//            int[] arr = { 1, 2, 3, 4, 5 };
//            IntArray a = new IntArray(arr);
//            foreach (int item in a)
//                Console.WriteLine(item);
//            Console.ReadKey();
//        }
//    }
//}