using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Video;

namespace Video
{
    static class MyExtensionMethod
    {
        public static string GetFullInfo(this Employee employee)
        {
            string str = "MyExtensionMethod";
            return $"{employee.FirstName} {employee.LastName}({employee.ID}) {employee.Salary} {str}";
        }
    }
}
