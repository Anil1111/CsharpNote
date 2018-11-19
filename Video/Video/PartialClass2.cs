using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Video
{
    public partial class Employee
    {
        partial void GetIdandSalary()
        {
            Console.WriteLine($"id={ID}, salary={Salary}");
        }
    }
}
