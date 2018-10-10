//using System;
//using System.Reflection;

//namespace Book
//{
//    class LimitedInt
//    {
//        public const int MaxValue = 100;
//        public const int MinValue = 0;

//        private int _theValue = 0;
//        public int TheValue
//        {
//            set
//            {
//                if (value < MinValue)
//                    _theValue = 0;
//                else
//                    _theValue = value > MaxValue ? MaxValue : value;
//            }
//            get
//            {
//                return _theValue;
//            }
//        }
//        public static LimitedInt operator -(LimitedInt x)
//        {
//            x.TheValue = 0;
//            return x;
//        }

//        public static LimitedInt operator -(LimitedInt x, LimitedInt y)
//        {
//            LimitedInt li = new LimitedInt();
//            li.TheValue = x.TheValue - y.TheValue;
//            return li;
//        }

//        public static LimitedInt operator +(LimitedInt x, double y)
//        {
//            LimitedInt li = new LimitedInt();
//            li.TheValue = x.TheValue + (int)y;
//            return li;
//        }

//    }
//    class Ch08Ex01
//    {
//        static void Main(string[] args)
//        {
//            LimitedInt li1 = new LimitedInt();
//            LimitedInt li2 = new LimitedInt();
//            LimitedInt li3 = new LimitedInt();
//            li1.TheValue = 10;
//            li2.TheValue = 26;
//            Console.WriteLine("li1:{0}, li2:{1}", li1.TheValue, li2.TheValue);

//            Console.WriteLine("{0} - {1} = {2}", li3.TheValue, li1.TheValue, (li3 - li1).TheValue);
//            Console.WriteLine("{0} - {1} = {2}", li2.TheValue, li1.TheValue, (li2 - li1).TheValue);
//            Console.WriteLine("{0} - {1} = {2}", li1.TheValue, li2.TheValue, (li1 - li2).TheValue);

//            Console.WriteLine("-{0} = {1}", li1.TheValue, -li1.TheValue);
//            Console.WriteLine("{0} + {1} = {2}", li1.TheValue, 6.2, (li1 + 6.2).TheValue);

//            Console.WriteLine("**************************************");

//            Type t = typeof(LimitedInt);
//            FieldInfo[] fi = t.GetFields();
//            MethodInfo[] mi = t.GetMethods();

//            foreach (FieldInfo f in fi)
//                Console.WriteLine("Field: {0}", f.Name);

//            Console.WriteLine("**************************************");

//            foreach (MethodInfo m in mi)
//                Console.WriteLine("Method: {0}", m.Name);

//            Console.ReadKey();
//        }
//    }
//}