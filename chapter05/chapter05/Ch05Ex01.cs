//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace chapter05
//{
//    class Ch05Ex01
//    {
//        static void Main(string[] args)
//        {
//            ushort destinatinVar;
//            char sourceVar = 'a';
//            destinatinVar = sourceVar;
//            Console.WriteLine($"sourceVar:{sourceVar}");
//            Console.WriteLine($"destinationVar:{destinatinVar}");
//            Console.WriteLine(destinatinVar.GetType());
//            Console.WriteLine(sourceVar.GetType());

//            decimal testvar = 12000;
//            Console.WriteLine(testvar);

//            short originalVar = 260;
//            byte convertVar;
//            convertVar = unchecked((byte)(originalVar));
//            Console.WriteLine($"oringinalvar: {originalVar}");
//            Console.WriteLine($"convertval: {convertVar}");

//            Console.WriteLine("****************************************");

//            short shortResult, shortVal = 4;
//            int integerVal = 67;
//            long longResult;
//            float floatVal = 10.6F;
//            double doubleResult, doubleVal = 99.999;
//            string stringResult, stringVal = "17";
//            bool boolVar = true;

//            Console.WriteLine("Variable Conversion Examples\n");
//            doubleResult = shortVal * (short)floatVal;
//            Console.WriteLine($"Implicit, -> double: {floatVal} * {shortVal} -> {doubleResult}");

//            shortResult = (short)floatVal;
//            Console.WriteLine($"Explict, -> short: {floatVal} -> {shortResult}");
//            stringResult = Convert.ToString(boolVar) + Convert.ToString(doubleVal);
//            Console.WriteLine($"Explicit, -> string: \"{boolVar}\" + \"{doubleVal}\" -> "
//                        + $"{stringResult}");

//            longResult = integerVal + Convert.ToInt64(stringVal);
//            Console.WriteLine($"Mixed, -> long:{integerVal} + {stringVal} -> {longResult}");

//            Console.ReadKey();
//        }
//    }
//}
