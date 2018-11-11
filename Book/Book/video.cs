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
            //string firstName, lastName;
            //Console.Write("Please input your first name:");
            //firstName = Console.ReadLine();
            //Console.Write("Please input your last name:");
            //lastName = Console.ReadLine();

            //int result = string.Compare(firstName, lastName, true);

            //Console.WriteLine(result);
            //string userName = " zhu shuai ";
            //Console.Write(userName.Trim()+"123");

            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < 10; i++)
                sb.Append(i.ToString());

            sb.Replace("123", "2222");
            Console.WriteLine(sb);

            Console.ReadKey();
        }

    }
}
