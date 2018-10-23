//using System;
//using System.Collections.Generic;

//namespace Book
//{
//    class Spectrum
//    {
//        bool _listFromUVtoIR;
//        string[] colors = { "violet", "blue", "cyan", "green", "yellow", "orange", "red" };
//        public Spectrum(bool listFromUVtoIR)
//        {
//            _listFromUVtoIR = listFromUVtoIR;
//        }
//        public IEnumerator<string> UVtoIR
//        {
//            get
//            {
//                for (int i = 0; i < colors.Length; i++)
//                    yield return colors[i];
//            }
//        }
//        public IEnumerator<string> IRtoUV
//        {
//            get
//            {
//                for (int i = colors.Length - 1; i >= 0; i--)
//                    yield return colors[i];
//            }
//        }
//        public IEnumerator<string> GetEnumerator()
//        {
//            return _listFromUVtoIR ? UVtoIR : IRtoUV;
//        }
//    }
//    class Ch18Ex08
//    {
//        static void Main()
//        {
//            Spectrum s1 = new Spectrum(true);
//            foreach (string item in s1)
//                Console.Write($"{item}\t");

//            Console.WriteLine();

//            Spectrum s2 = new Spectrum(false);
//            foreach (string item in s2)
//                Console.Write($"{item}\t");
//            Console.ReadKey();
//        }
//    }
//}