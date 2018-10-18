//using System;

//namespace Book
//{
//    class Animal { public string name; }
//    class Dog : Animal { }
//    interface IMyIfc<out T>
//    {
//        T GetFirst();
//    }
//    class SimpleReturn<T>:IMyIfc<T>
//    {
//        public T[] items = new T[2];
//        public T GetFirst()
//        {
//            return items[0];
//        }
//    }
//    class Ch17Ex09
//    {
//        static void DoSomething(IMyIfc<Animal> returner)
//        {
//            Console.WriteLine(returner.GetFirst().name);
//        }
//        static void Main()
//        {
//            SimpleReturn<Dog> dogReturner = new SimpleReturn<Dog>();
//            dogReturner.items[0] = new Dog();
//            dogReturner.items[0].name = "Avonlea";
//            IMyIfc<Animal> animalReturner = dogReturner;
//            DoSomething(animalReturner);

//            Console.ReadKey();
//        }
//    }
//}