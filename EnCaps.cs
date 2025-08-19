using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class EnCaps
    {
        public string name;
        private static int num;


        public static int Num { get => num; set => num = value; }
    }

    class Test
    {
        public void OkTest()
        {
            //EnCaps ec = new EnCaps();
            //ec.name = "Dervin";
            //EnCaps.Num = 22;
            //Console.WriteLine($"My name is {ec.name}, My age is {EnCaps.Num} ");

            Construct con = new Construct("Loras" , 28);
            con.PrintValue();
            Construct con1 = new Construct("Tywin", 60);
            con1.PrintValue();
            Construct con2 = new Construct();
            con2.PrintValue();
        }
    }

    class Construct
    {
        public string name;
        public int age;

        public Construct()
        {
            this.name = "Your Name";
            this.age = 0;
        }

        public Construct(string name ,int age)
        {
            this.name = name;
            this.age = age;
        }

        public void PrintValue()
        {

            int age = 10;
            Console.WriteLine($"{this.name} , {this.age} , {age}");
        }
    }
}
