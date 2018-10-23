//using System;

//namespace Book
//{
//    struct PieceofData<T>
//    {
//        public PieceofData(T value)
//        {
//            _data = value;
//        }
//        private T _data;
//        public T Data
//        {
//            get
//            {
//                return _data;
//            }
//            set
//            {
//                _data = value;
//            }
//        }
//    }
//    class Ch17Ex04
//    {
//        static void Main()
//        {
//            var s1 = new PieceofData<int>(12);
//            var s2 = new PieceofData<string>("Hi there");
//            Console.WriteLine("IntData      = {0}", s1.Data);
//            Console.WriteLine("StringData   = {0}", s2.Data);

//            Console.ReadKey();
//        }
//    }
//}