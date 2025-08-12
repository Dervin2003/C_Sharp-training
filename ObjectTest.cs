using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class ObjectTest
    {
        public void ObjTest()
        {
            object objA = new object();
            object objB = new object();
            objA = 1;
            objB = 1;
            //objA = objB;
            bool areEqual = ReferenceEquals(objA, objB);
            if(areEqual)
            {
                Console.WriteLine($"objA:{objA} , objB:{objB}");
                Console.WriteLine("Objects are the same instance or both are null.");
            }
            else
            {
                Console.WriteLine($"objA:{objA} , objB:{objB}");
                Console.WriteLine("Objects are different instances.");
            }
        }
    }
}
