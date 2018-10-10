//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace chapter09
//{
//    // 抽象类只可以被继承，不可以实例化
//    public abstract class MyBase { }
//    // 内部类继承自公开类
//    internal class MyClass : MyBase { }
//    // 公开接口
//    public interface IMyBaseInterface { }
//    internal interface IMyBaseInterface2 { }
//    internal interface IMyinerface : IMyBaseInterface, IMyBaseInterface2 { }
//    internal sealed class MyComplexClass : MyClass, IMyinerface { }
//    class Ch09Ex01
//    {
//        static void Main(string[] args)
//        {
//            MyComplexClass myObj = new MyComplexClass();
//            Console.WriteLine(myObj.ToString());

//            Console.ReadKey();
//        }
//    }
//}
