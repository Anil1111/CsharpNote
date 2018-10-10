using System;
// 类数组的简单测试
namespace Book
{
    class MyClass
    {
        public int a;
        public int b;
        public MyClass(int a, int b)
        {
            this.a = a;
            this.b = b;
        }
    }
    class Ch12Ex01
    {
        static void Main()
        {
            MyClass[] myClassArr = new MyClass[3];
            myClassArr[0] = new MyClass(1, 2);
            Console.WriteLine(myClassArr[0].a);

            Console.ReadKey();
        }
    }
}