using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Video
{
    static class MyExtensionMethod
    {
        public static int MyListCount<T>(this IEnumerable<T> list) //给实例添加方法
        {
            int sum = 0;
            var e = list.GetEnumerator();
            while(e.MoveNext())
            {
                sum++;
            }
            return sum;
        }
    }
}
