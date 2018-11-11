using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Book
{
    class video
    {
        static void Main(string[] args)
        {
            var list = new List<int>();
            for (int i = 0; i < 8; i++)
                list.Add(i);

            Add(list);

            foreach(var item in list)
                Console.WriteLine(item);


            Console.ReadKey();
        }

        static void Add(List<int> list)
        {
            list.Add(10);
        }
    }
}
