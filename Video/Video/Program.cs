using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.IO;
using System.Collections;

namespace Video
{
    class MyList:IEnumerable<int>
    {
        public MyList(int n)
        {
            Nums = new int[n];
            var r = new Random();
            for (int i = 0; i < n; i++)
            {
                Nums[i] = r.Next(1, 10);
            }

        }
        private int[] Nums;

        public IEnumerator<int> GetEnumerator()
        {
            foreach (var item in Nums)
                yield return item;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
    class MyList2 : IEnumerable<int>
    {
        public MyList2(int n)
        {
            Nums = new int[n];
            var r = new Random();
            for (int i = 0; i < n; i++)
            {
                Nums[i] = r.Next(1, 10);
            }
        }
        private int[] Nums;

        public IEnumerator<int> GetEnumerator()
        {
            foreach (var item in Nums)
                yield return item;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var list = new MyList(5);
            foreach(var item in list)
                Console.WriteLine(item);

            Console.WriteLine();

            Console.WriteLine(list.MyListCount());


            Console.ReadKey();
        }

    }
}