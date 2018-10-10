using System;

namespace chapter04

{
    class Ch04Ex02
    {
        static void Main(string[] args)
        {
            string comparison;
            Console.WriteLine("Number:");
            double var1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Anther Number:");
            double var2 = Convert.ToDouble(Console.ReadLine());
            if (var1 < var2)
                comparison = "less than";
            else
            {
                if (var1 == var2)
                    comparison = "equal to";
                else
                {
                    comparison = "greater than";
                }
            }

            Console.WriteLine($"{var1} {comparison} {var2}");

            Console.ReadKey();
        }
    }
}