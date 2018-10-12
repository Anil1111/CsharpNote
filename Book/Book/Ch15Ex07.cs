//using System;

//namespace Book
//{
//    interface IGetData
//    {
//        int GetData();
//    }
//    interface ISetData
//    {
//        void SetData(int x);
//    }
//    interface INumber:IGetData,ISetData
//    { }

//    class MyClass:INumber
//    {
//        public int mem;
//        public int GetData()
//        {
//            return mem;
//        }
//        public void SetData(int x)
//        {
//            mem = x;
//        }
//    }

//    class Ch15Ex07
//    {
//        static void Main()
//        {
//            MyClass mc = new MyClass();
//            mc.SetData(12);
//            Console.WriteLine(mc.GetData());

//            Person p1 = new Boy("zhushuai", 23, 'm');
//            p1.Show();

//            Console.ReadKey();
//        }
//    }
//    class Person
//    {
//        public string name;
//        public int age;
//        public Person(string name, int age)
//        {
//            this.name = name;
//            this.age = age;
//        }
//        public void Show()
//        {
//            Console.WriteLine("Person Info:\nName:{0}\nAge:{1}", name, age);
//        }
//    }
//    class Boy:Person
//    {
//        public char sex;
//        public Boy(string name, int age, char sex):base(name, age)
//        {
//            this.sex = sex;
//        }
//        new public void Show()
//        {
//            Console.WriteLine("Person Info:\nName:{0}\nAge:{1}\nSex:{2}", name, age, sex);
//        }
//    }
//}