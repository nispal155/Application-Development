using System;

namespace task3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declare and initialize variables of different data types
            byte byteVar = 10;
            short shortVar = 200;
            int intVar = 42;
            long longVar = 1234567890L;
            float floatVar = 5.75F;
            double doubleVar = 19.99;
            decimal decimalVar = 1000.50M;
            char charVar = 'A';
            bool boolVar = true;

            // Type conversions
            string intToString = intVar.ToString(); // Converting int to string
            string strValue = "3.14";
            double stringToDouble = Convert.ToDouble(strValue); // Converting string to double

            // Printing all variables with type and value
            Console.WriteLine("----- Data Types and Their Values -----");
            Console.WriteLine($"byte: {byteVar}");
            Console.WriteLine($"short: {shortVar}");
            Console.WriteLine($"int: {intVar}");
            Console.WriteLine($"long: {longVar}");
            Console.WriteLine($"float: {floatVar}");
            Console.WriteLine($"double: {doubleVar}");
            Console.WriteLine($"decimal: {decimalVar}");
            Console.WriteLine($"char: {charVar}");
            Console.WriteLine($"bool: {boolVar}");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine($"Converted int (42) to string: \"{intToString}\"");
            Console.WriteLine($"Converted string (\"3.14\") to double: {stringToDouble}");
        }
    }
}