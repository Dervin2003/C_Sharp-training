using System;

namespace ConsoleApp2
{
    internal class Class1
    {
        public void DataTypes()
        {   byte myByte = 2;
            short myShort = 32;
            int myInt = 21;
            long myLong = 92;
            float myFloat = 3.4f;
            double myDouble = 1.7976931348;
            char myChar = 'A';
            bool myBool = true;
            string myString = "Hello World";
            object myObject = new object();
            Console.WriteLine($"Byte: {myByte}, Short: {myShort}, Int: {myInt}, Long: {myLong}, Float: {myFloat}, Double: {myDouble}, Char: {myChar}, Bollean: {myBool}, String: {myString}, Object: {myObject}");
        }

        public void ArithOperators()
        {
            int a = 5;
            int b = 10;
            int sum = a + b;
            Console.WriteLine($"Sum: {sum}");
            int product = a * b;
            Console.WriteLine($"Product: {product}");
            int difference = b - a;
            Console.WriteLine($"Difference: {difference}");
            int quotient = b / a;
            Console.WriteLine($"Quotient: {quotient}");
            int remainder = b % a;
            Console.WriteLine($"Remainder: {remainder}");
            int incremented = a++;
            Console.WriteLine($"Incremented a: {incremented}");
            int decremented = b--;
            Console.WriteLine($"Decremented b: {decremented}");
            int compoundSum = a += b;
            Console.WriteLine($"Compound Sum (a += b): {compoundSum}");
            int compoundDifference = b -= a;
            Console.WriteLine($"Compound Difference (b -= a): {compoundDifference}");
        }

        public void LogicOperators()
        {
            bool x = true;
            bool y = false;
            Console.WriteLine($"x AND y: {x && y}");
            Console.WriteLine($"x OR y: {x || y}");
            Console.WriteLine($"NOT x: {!x}");
        }
        public void TypeCasting()
        {
            double myDouble = 9.78;
            int myInt = (int)myDouble;
            Console.WriteLine($"Double: {myDouble}, Casted to Int: {myInt}");
            
            int anotherInt = 5;
            double anotherDouble = anotherInt;
            Console.WriteLine($"Int: {anotherInt}, Implicitly Casted to Double: {anotherDouble}");
        }
    }
}
