using System;

namespace chapter10
{
    public interface IMyInterface
    {
        void DoSomething();
        void DoSomethingElse();
    }
    public class MyBaseClass:IMyInterface
    {
        public virtual void DoSomething()
        {
            Console.WriteLine("DoSomething");
        }
        public virtual void DoSomethingElse()
        {
            Console.WriteLine("DoSomethingElse");
        }
    }
    public class MyClass:MyBaseClass
    {
        //public override void DoSomething()
        //{
        //    Console.WriteLine("DoSomething override");
        //}
        new public void DoSomething()
        {
            Console.WriteLine("DoSomething override");
        }
        public void DoSomethingNew()
        {

        }
    }

    class Ch10Ex04
    {
        static void Main()
        { 
            IMyInterface A = new MyClass();
            A.DoSomething();

            Console.ReadKey();
        }
    }
}