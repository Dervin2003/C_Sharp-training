using System;

namespace ConsoleApp2
{
    class EnCaps
    {
        public string name;
        private static int num;
        private static int num2;


        public static int Num { get => num; set => num = value; }
        public int Num2 { get { return num2; } set { num2 = value; } }
    }

    class Test
    {
        public void OkTest()
        {
            EnCaps ec = new EnCaps()
            {
                name = "Batman",
                Num2 = 45
            };
            EnCaps.Num = 40;
            Console.WriteLine($"My name is {ec.name}, My age is between {EnCaps.Num} to {ec.Num2}");

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
