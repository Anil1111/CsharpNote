//using System;
//using System.Collections;

//namespace Book
//{
//    class ColorEnumerator: IEnumerator
//    {
//        string[] _colors;
//        int _position = -1;
//        public ColorEnumerator(string[] thecolors)
//        {
//            _colors = new string[thecolors.Length];
//            for (int i = 0; i < thecolors.Length; ++i)
//            {
//                _colors[i] = thecolors[i];
//            }
//        }
//        public object Current
//        {
//            get
//            {
//                if (_position == -1)
//                    throw new InvalidOperationException();
//                if (_position >= _colors.Length)
//                    throw new InvalidOperationException();
//                return _colors[_position];
//            }
//        }
//        public bool MoveNext()
//        {
//            if (_position < _colors.Length - 1)
//            {
//                _position++;
//                return true;
//            }
//            else
//                return false;
//        }
//        public void Reset()
//        {
//            _position = -1;
//        }
//    }
//    class Spectrum:IEnumerable
//    {
//        string[] colors = { "violet", "blue", "cyan", "green", "yellow", "orange", "red" };
//        public IEnumerator GetEnumerator()
//        {
//            return new ColorEnumerator(colors);
//        }
//    }
//    class Ch18Ex02
//    {
//        static void Main()
//        {
//            Spectrum s = new Spectrum();
//            foreach (string color in s)
//                Console.WriteLine(color);

//            Console.ReadKey();
//        }
//    }
//}