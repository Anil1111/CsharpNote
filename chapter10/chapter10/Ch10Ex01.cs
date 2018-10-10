//using System;
////using Demo;

//namespace chapter10
//{
//    //class MyClass
//    //{
//    //    //public MyClass(int MyInt)
//    //    //{
//    //    //    this.MyInt = MyInt;
//    //    //}
//    //    public readonly int MyInt1 = 13;
//    //    public static int MyInt2;
//    //    private int myInt3 = 15;
//    //    internal int myInt4 = 16;
//    //    protected int myInt5 = 17;
//    //    public void Show()
//    //    {
//    //        Console.WriteLine($"myInt3={myInt3}");
//    //        Console.WriteLine($"myInt5={myInt5}");
//    //    }

//    //}
//    //class DeClass:MyClass
//    //{
//    //    public void Display()
//    //    {
//    //        Console.WriteLine($"myInt5={myInt5}");
//    //    }
//    //}
    
//    class MyBaseClass
//    {
//        public virtual void DoSomeThing()
//        {
//            Console.WriteLine("这是基类的virtual方法");
//        }
//    }

//    class MyDerivedClass:MyBaseClass
//    {
//        public sealed override void DoSomeThing()
//        {
//            Console.WriteLine("这是派生类重写的方法");
//        }
//    }

//    class MyLastDerivedClass:MyDerivedClass
//    {
//        //public override void DoSomeThing()
//        //{

//        //}
//    }

//    abstract class VMyBaseClass
//    {
//        public abstract void DoSomeThing();
//    }

//    class VMyDerivedClass:VMyBaseClass
//    {
//        public override void DoSomeThing()
//        {
//            Console.WriteLine("这是抽象类的继承类的方法");
//        }
//    }

//    class Ch10Ex01
//    {
//        static void Main(string[] args)
//        {
//            //MyClass A1 = new MyClass();
//            //MyClass.MyInt2 = 12;
//            //Console.WriteLine($"A1.MyInt1={A1.MyInt1}");
//            //Console.WriteLine($"MyClass.MyInt2={MyClass.MyInt2}");
//            //Console.WriteLine($"A1.myInt4={A1.myInt4}");
//            //A1.Show();

//            //DeClass B1 = new DeClass();
//            //B1.Display();

//            //Demo.Test C1 = new Demo.Test();
//            //C1.Exhibit();
//            MyBaseClass A = new MyBaseClass();
//            MyDerivedClass B = new MyDerivedClass();
//            A.DoSomeThing();
//            B.DoSomeThing();

//            VMyDerivedClass C = new VMyDerivedClass();
//            C.DoSomeThing();

//            Console.ReadKey();
//        }
//    }
//}

////namespace Demo
////{
////    class Test
////    {
////        public void Exhibit()
////        {
////            chapter10.MyClass A1 = new chapter10.MyClass();
////            Console.WriteLine($"myInt4={A1.myInt4}");
////        }
////    }
////}