//using System;

//namespace Book
//{
//    [Flags]
//    enum CardDeckSettings : uint
//    {
//        SingleDeck      = 0x01,
//        LargePictures   = 0x02,
//        FancyNumbers    = 0x04,
//        Animation       = 0x08
//    }

//    class MyClass
//    {
//        bool UseSingleDeck                  = false,
//             UseLargePictures               = false,
//             UseFancyNumbers                = false,
//             UseAnimation                   = false,
//             UseAnimationAndFancyNumbers    = false;
//        public void CheckOptions(CardDeckSettings ops)
//        {
//            UseSingleDeck       = ops.HasFlag(CardDeckSettings.SingleDeck);
//            UseLargePictures    = ops.HasFlag(CardDeckSettings.LargePictures);
//            UseFancyNumbers     = ops.HasFlag(CardDeckSettings.FancyNumbers);
//            UseAnimation        = ops.HasFlag(CardDeckSettings.Animation);

//            CardDeckSettings testFlag = CardDeckSettings.Animation | CardDeckSettings.FancyNumbers;
//            UseAnimationAndFancyNumbers = ops.HasFlag(testFlag);
//        }

//        public void ShowOptions()
//        {
//            Console.WriteLine("Option settings:");
//            Console.WriteLine($"    Use Single Deck                     -{UseSingleDeck}.");
//            Console.WriteLine($"    Use Large Pictures                  -{UseLargePictures}.");
//            Console.WriteLine($"    Use Fancy Numbers                   -{UseFancyNumbers}.");
//            Console.WriteLine($"    Use Animation                       -{UseAnimation}.");
//            Console.WriteLine($"    Use Animation And Fancy Numbers     -{UseAnimationAndFancyNumbers}.");
//        }

//    }

//    class Ch11Ex02
//    {

//        static void Main()
//        {
//            MyClass mc = new MyClass();
//            CardDeckSettings ops = (CardDeckSettings)15;
//            mc.CheckOptions(ops);
//            mc.ShowOptions();

//            Console.WriteLine(CardDeckSettings.Animation);

//            Console.WriteLine(Enum.GetName(typeof(Book.CardDeckSettings), 1));

//        Console.ReadKey();
//        }
//    }
//}