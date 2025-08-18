using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    using System;

    internal class MethodS
    {
        public void RefOutTest()
        {
            int number = 10;
            int result;

            Console.WriteLine("Before method call: " + number);

            ModifyValue(ref number, out result);

            Console.WriteLine("After method call (ref): " + number);
            Console.WriteLine("Out value returned: " + result);
        }

        public static void ModifyValue(ref int value, out int result)
        {
            value *= 2;
            result = value + 5;
            Console.WriteLine("Inside method (ref modified): " + value);
            Console.WriteLine("Inside method (out assigned): " + result);
        }
    }

    class InheritTest
    {
        public void Function()
        {

        }
        public virtual void MainMethod()
        {
            Console.WriteLine("I am from parent class");
        }
    }

    class Child : InheritTest
    {
        public override void MainMethod()
        {
            Console.WriteLine("I am from child class");
        }

    }

    class OverLoad
    {
        public void Add(int a , int b)
        {
            Console.WriteLine(a+b);
        }

        public void Add(int a, int b , int c)
        {
            Console.WriteLine(a+b+c);
        }

        public void Add(double a,double b)
        {
            Console.WriteLine(a+b);
        }
    }


    class Recursion
    {
        public static int Fact (int num)
        {
            if (num == 0 || num == 1)
            {
                return 1;
            }
            else
            {
                return num * Fact(num - 1);
            }
        }

        public void Call()
        {
            int result = Fact(5);
            Console.WriteLine(result);
        }
    }
}
