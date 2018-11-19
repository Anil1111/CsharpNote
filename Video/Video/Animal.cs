using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Video
{
    class Animal
    {
        private string _Name;
        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }
        public int Age { get; set; }
        public Animal(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }
    //子类可以使用扩展方法是因为他可以隐形转换成基类。并不是因为他从基类继承了这个方法；
    class Dog : Animal
    {
        public string Category { get; set; }
        public Dog(string name, int age, string category) : base(name, age)
        {
            Category = category;
        }
        public void Bark()
        {
            Console.WriteLine("wowowow");
        }
    }
}
