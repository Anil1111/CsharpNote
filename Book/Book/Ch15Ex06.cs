//using System;

//namespace Book
//{
//    interface IShow
//    {
//        void Show(string s);
//    }

//    class CBase
//    {
//        public string name;
//        public int age;
//        public CBase(string name, int age)
//        {
//            this.name = name;
//            this.age = age;
//        }
//        public void Show(string s)
//        {
//            Console.WriteLine("Calling in: {0}", s);
//        }
//    }

//    interface IIfc1
//    {
//        void PrintOut(string s);
//    }

//    interface IIfc2
//    {
//        void PrintOut(string s);
//    }

//    class MyClass:IIfc1, IIfc2
//    {
//        void IIfc1.PrintOut(string s)
//        {
//            Console.WriteLine("string {0} in interface 1", s);
//        }
//        void IIfc2.PrintOut(string s)
//        {
//            Console.WriteLine("string {0} in interface 2", s);
//        }
//    }

//    class CDerived:CBase, IShow
//    {
//        public char sex;
//        public CDerived(string name, int age, char sex):base(name, age)
//        {
//            this.sex = sex;
//        }
//    }

//    class Ch15Ex06
//    {
//        static void Main()
//        {
//            CDerived cd = new CDerived("zhushuai", 23, 'm');
//            cd.Show("subclass");

//            IShow show = cd as IShow;
//            show.Show("Interface");

//            Console.WriteLine("****************************");
//            MyClass mc = new MyClass();

//            IIfc1 ifc1 = (IIfc1)mc;
//            ifc1.PrintOut("zhushuai");

//            IIfc2 ifc2 = mc as IIfc2;
//            ifc2.PrintOut("zhushuai");


//            Console.ReadKey();
//        }
//    }
//}