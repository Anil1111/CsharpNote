using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Video
{
    class A
    {
        public virtual void Func()
        {
            Console.WriteLine("function in class A");
        }
    }
    class B : A
    {
        public override void Func()
        {
            Console.WriteLine("function in class B");
        }
    }
    class C : B
    {
        public override void Func()
        {
            Console.WriteLine("function in class C");
        }
    }
    class D : A
    {
        public new void Func()
        {
            Console.WriteLine("function in class D");
        }
    }
    class E : D
    {
        public new void Func()
        {
            Console.WriteLine("function in class E");
        }
    }
    class F : A
    {
        private new void Func()
        {
            Console.WriteLine("function in class F");
        }
        public void ShowFunc()
        {
            Func();
        }
    }
    class G : F
    {

    }
}
