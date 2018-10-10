//using System;

//namespace Book
//{
//    enum TrafficLight:byte
//    {
//        Green=0,
//        Yellow=1,
//        Red=1
//    }
//    [Flags]
//    enum CardDeckSettings:uint
//    {
//        SingleDeck = 0x01,
//        LargePictures = 0x02,
//        FancyNumbers = 0x04,
//        Animation = 0x08
//    }

//    class Ch11Ex01
//    {
//        static void Main()
//        {
//            TrafficLight t1 = TrafficLight.Green;
//            Console.WriteLine($"TrafficLight.t1 = {t1}");
//            Console.WriteLine($"TrafficLight.t1 = {(int)t1}");
//            Console.WriteLine($"TrafficLight.t1 = {t1.GetType()}");

//            TrafficLight t2 = (TrafficLight)1;
//            Console.WriteLine(t2);

//            // CardDeckSettings ops = CardDeckSettings.Animation | CardDeckSettings.FancyNumbers | CardDeckSettings.LargePictures;
//            CardDeckSettings ops = (CardDeckSettings)14;

//            Console.WriteLine(ops.ToString());

//            bool testFlag = (ops & CardDeckSettings.Animation) == CardDeckSettings.Animation;
//            Console.WriteLine(testFlag);

//            CardDeckSettings testVal = CardDeckSettings.Animation | CardDeckSettings.FancyNumbers;
//            bool mulTest = ops.HasFlag(testVal);
//            Console.WriteLine(mulTest);

//            Console.ReadKey();
//        }
//    }
//}