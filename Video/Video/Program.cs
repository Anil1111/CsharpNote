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
    class  A
    {
        public A(int a)
        {
            this.a = a;
        }
        public int a;
    }
    class Program
    {
        static void Main(string[] args)
        {
            string reverse, palindrome;
            char[] temp;

            Console.WriteLine("Enter a palindrome:");
            palindrome = Console.ReadLine();
            reverse = palindrome.Replace(" ", ",");
            temp = reverse.ToCharArray();

            Array.Reverse(temp);

            if(reverse == new string(temp))
            {
                Console.WriteLine($"\"{palindrome}\" is a palindrome.");
            }
            else
                Console.WriteLine($"\"{palindrome}\" is not a palindrome.");

            string str = new string('1', '2');
            Console.WriteLine(str);
            decimal d1 = 0.123456789123456789M;
            Console.WriteLine(d1);

            Console.ReadKey();
        }
<<<<<<< HEAD
    }
=======
   }
>>>>>>> d055a9cb27800dc0ac9a776106a71acd4d318f98
}