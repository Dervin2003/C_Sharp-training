using System;

namespace ConsoleApp2
{
    internal class Class1
    {
        public void DataTypes()
        {   byte myByte = 2;
            short myShort = 32767;
            int myInt = 2147483647;
            long myLong = 9223372036854775807;
            float myFloat = 3.40282347E+38F;
            double myDouble = 1.7976931348623157E+308;
            char myChar = 'A';
            bool myBool = true;
            string myString = "Hello World";
            object myObject = new object();
            Console.WriteLine($"Byte: {myByte}, Short: {myShort}, Int: {myInt}, Long: {myLong}, Float:{myFloat}");
        }

        public void MemoryTypes()
        {
            int stackValue = 42;
            string heapValue = "Hello, Heap!";
            Console.WriteLine($"Stack Value: {stackValue}, Heap Value: {heapValue}");
        }
        public void Operators()
        {
            int a = 5;
            int b = 10;
            int sum = a + b;
            Console.WriteLine($"Sum: {sum}");
            a++;
            Console.WriteLine($"Incremented a: {a}");
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
