//using System;

//namespace Book
//{
//    struct Ssample
//    {
//        public Ssample(int x, int y)
//        {
//            this.x = x;
//            this.y = y;
//        }

//        public int x;
//        public int y;
        
//        public void Show()
//        {
//            Console.WriteLine($"x = {x}, y = {y}");
//        }
//    }

//    class Csample
//    {
//        public int x;
//        public int y;
//        public static int z;
//        static Csample()
//        {
//            z = 12;
//        }
//    }

//    class Ch10Ex01
//    {
//        static void Main()
//        {
//            Ssample sr;
//            Ssample s1 = new Ssample(1, 2);
//            Ssample s2 = new Ssample(3, 4);
//            sr = struct_Add(ref s1, ref s2);
//            sr.Show();
//            s1.Show();
//            s2.Show();

//            Csample c1 = new Csample();
//            c1.x = 12;
//            c1.y = 13;
//            Console.WriteLine(Csample.z);
//            Console.ReadKey();
//        }

//        static Ssample struct_Add(ref Ssample s1, ref Ssample s2)
//        {
//            Ssample sr;
//            sr.x = s1.x + s2.x;
//            sr.y = s1.y + s2.y;
//            s1.x++;
//            s2.y++;
//            return sr;
//        }
//    }
//}