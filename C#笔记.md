# C#笔记
1. 字面值的默认类型
       整数默认为int类型
       小数默认为double类型
2. 指数类型例如1e10为double类型
3. 在string类型中@可以忽略后面的字符串中的转移字符的作用
4. 字符的不可变性
	```cs
	string str = "abc";
    str.ToUpper();
    Console.WriteLine(str);
    //out: abc
	```
    ```cs
    string str = "abc";
    str = str.ToUpper();
    Console.WriteLine(str);
    //or Console.WriteLine(str.ToUpper());
    //out: ABC
    ```
    ToUpper()方法具有返回值，但是在执行过程中不会改变本来的字符串的值，如果相对数据进行更改，需要对变量名称进行重新赋值。
5. string和stringBuilger
 - string在需要大量进行重复操作字符串时候耗时较长
 - stringBuilder相比于string速度会有明显提升
	```cs
	using System.Diagnostics;
    Stopwatch timer = new Stopwatch();
	timer.Start();
    StringBuilder sb = new StringBuilder();
    for (int i = 0; i < 1000; i++)
    	sb.Append(i.ToString());
	Console.WriteLine(timer.ElapsedMilliseconds);
    timer.Stop();
    //out:近似0
	```
    ```cs
    using System.Diagnostics;
    Stopwatch timer = new Stopwatch();
	timer.Start();
	string str = string.Empty;
	for (int i = 0; i < 10000; i++)
    	str += i.ToString();
    Console.WriteLine(timer.ElapsedMilliseconds);
    timer.Stop();
    //out:69ms
    ```
6. 可空修饰
	```cs
    //int num = null;
    //error;
    //null 不可以转换成 int
	int? num = null;
    Console.WriteLine(num);
    //out:无字符显示
    ```
7. 数据转换
 - 显式转换--由高到低
 	```cs
    long a = 1;
    int b = 2;
    b = (int)a;
    ```
    这种情况下有可能出现数据的溢出
    ```cs
    int a = int.MaxValue;
    a = a + 1;
    Console.WriteLine(a);
    //out:-2147483648
    ```
    为了避免这种情况为程序带来的危害，使用checked语句块
    ```cs
    checked
    {
    	int a = int.MaxValue;
    	a = a + 1;
    	Console.WriteLine(a);
    }
    //out:抛出数据溢出异常
    ```
 - 隐式转换--由低到高
 	```cs
    long a = 1;
    int b = 2;
    a = b;
    ```
    ```cs
    int b = int.MaxValue;
    long a = b;
    a = a + 1;
    Console.WriteLine(a);
    //out:2147483648
    ```
 - 函数转换
 	- Parse():将数字形式的字符串转换成字面值与之等价的32位整形，功能类似python中的int()函数
 		```cs
        var str1 = Console.ReadLine();
        var str2 = Console.ReadLine();

        int a1 = int.Parse(str1);
        int a2 = int.Parse(str2);

        Console.WriteLine(a1 + a2);
        // in: "1"  "2"
        // out: 3
        ```
	- TryParse():int的静态成员函数，如果输入的数字则返回true，否则返回false
	- ToString()：数据类型的普通成员函数。
8. 三元运算符？：嵌套使用
	```cs
    int a = int.Parse(Console.ReadLine());
    int b = int.Parse(Console.ReadLine());
    int c = int.Parse(Console.ReadLine());
    var d = (a > b ? a : b) > c ? (a > b ? a : b) : c;
    ```
9. 空接合运算符
	```cs
    string fileName = null;
    fileName = fileName??"DefaultName.txt";
    //如果fileName中是空返回DefaultName.txt，不是空则返回本来的内容
    ```
10. 预处理指令
	```cs
	#region sum
	double sum = 0;
	for (double i = 1; i < 100; i++)
		sum += i / (i + 1);
	Console.WriteLine(sum);
	#endregion
	```
	没有实际的意义，只是在阅读代码时可以压缩代码块。
11. 类中的非static函数可以调用任意函数，static函数只可以调用static函数
12. C#中为什么Main()函数需要设置为static?
	假设没有static关键字,那意味着需要用生成一个实例后才可以调用这个Ｍain方法,而Ｍain方法是程序入口点，你没有进入Ｍain方法,自然无法生成一个实例,既然没有实例，那就无法调用Ｍain函数，岂不矛盾?所以Ｍain函数被设置为static.
13. 