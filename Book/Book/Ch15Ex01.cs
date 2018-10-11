using System;

namespace Book
{
    interface Iinfo
    {
        string GetName();
        string GetAge();
    }

    class CA:Iinfo
    {
        public string name;
        public int age;
        public CA(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
        public string GetName()
        {
            return name;
        }
        public string GetAge()
        {
            return age.ToString();
        }
    }
    class CB:Iinfo
    {
        public string First;
        public string Last;
        public double PersonsAge;
        public CB(string first, string last, double personsage)
        {
            this.First = first;
            this.Last = last;
            this.PersonsAge = personsage;
        }
        public string GetName()
        {
            return First + " " + Last;
        }
        public string GetAge()
        {
            return PersonsAge.ToString();
        }
    }
    class Ch15Ex01
    {
        static void Main()
        {
            CA a = new CA("John Doe", 35);
            CB b = new CB("John", "Doe", 35);
            Show(a);
            Show(b);

            Boy boy = new Boy("abc", 12, 'f');
            Show(boy);

            Console.ReadKey();
        }

        static void Show(Iinfo item)
        {
            Console.WriteLine("Name: {0}, Age: {1}", item.GetName(), item.GetAge());
        }
        /*
         * 这种情况可以用类的继承来理解
         * 对于继承自person的子类boy
         * 当一个函数里面接收的参数应该是父类person的时候
         * 如果此时传递进去的是子类boy的实例
         * 函数照样可以正确运行
         * 同理，可以把实例化接口的类或者结构理解成继承自接口的子类
         * 所以在函数中定义接口的部分可以直接将类实例传入
         */
        static void Show(Person p)
        {
            Console.WriteLine("This is a person:\nname:{0}\nage:{1}", p.name, p.age);
        }
    }
    class Person
    {
        public string name;
        public int age;
        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
    }
    class Boy:Person
    {
        public char sex;
        public Boy(string name, int age, char sex):base(name, age)
        {
            this.sex = sex;
        }
    }
}