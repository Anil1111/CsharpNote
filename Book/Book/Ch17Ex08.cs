//using System;

//namespace Book
//{
//    delegate T Factory<out T>();
//    delegate void Action1<in T>(T a);
//    class Animal
//    {
//        public int NumberOfLegs = 4;
//        public string name;
//        public int age;
//        public Animal(string name, int age)
//        {
//            this.name = name;
//            this.age = age;
//        }
//        public void Print()
//        {
//            Console.WriteLine("Animal info");
//            Console.WriteLine("Name:{0}\nAge:{1}", name, age);
//        }
//    }
//    class Dog:Animal
//    {
//        char sex;
//        public Dog(string name, int age, char sex):base(name, age)
//        {
//            this.sex = sex;
//        }
//        new public void Print()
//        {
//            Console.WriteLine("Dog info");
//            Console.WriteLine("Name:{0}\nAge:{1}\nSex:{2}", name, age, sex);
//        }
//    }
//    class Ch17Ex08
//    {
//        static void ActOnAnimal(Animal a)
//        {
//            Console.WriteLine(a.NumberOfLegs);
//        }
//        static Dog MakeDog()
//        {
//            return new Dog("Tobby", 4, 'm');
//        }
//        static void Main()
//        {
//            Factory<Dog> dogMaker = MakeDog;
//            Factory<Animal> animalMaker = dogMaker;
//            Animal a = animalMaker();
//            a.Print();


//            Action<Animal> a1 = ActOnAnimal;
//            Action<Dog> d1 = a1;
//            d1(dogMaker());

//            Console.ReadKey();
//        }
//    }
//}