//using System;

//namespace Book
//{
//    interface ILiveBirth
//    {
//        string BabyCalled();
//    }

//    class Animal { }
//    class Cat:Animal, ILiveBirth
//    {
//        public string BabyCalled()
//        {
//            return "Kitty";
//        }
//    }
//    class Dog:Animal, ILiveBirth
//    {
//        public string BabyCalled()
//        {
//            return "Puppy";
//        }
//    }
//    class Bird:Animal
//    {

//    }
//    class Ch15Ex08
//    {
//        static void Main()
//        {
//            Animal[] animalarray = new Animal[3];
//            animalarray[0] = new Cat();
//            animalarray[1] = new Dog();
//            animalarray[2] = new Bird();

//            foreach(Animal animal in animalarray)
//            {
//                ILiveBirth b = animal as ILiveBirth;
//                if (b != null)
//                    Console.WriteLine("Baby is called: {0}", b.BabyCalled());
//            }

//            Console.ReadKey();
//        }
//    }
//}