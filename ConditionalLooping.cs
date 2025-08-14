using System;

namespace ConsoleApp2
{
    internal class ConditionalLooping
    {
        public void BreakTest()
        {
            Console.WriteLine("Break Statement");
            for (int i = 0; i < 10; i++) {

                if (i==5)
                {
                    break;
                }
                Console.WriteLine(i);
            }
        }

        public void ContinueTest()
        {
            Console.WriteLine("Continue Statement");
            for (int i = 0; i < 10; i++)
            {

                if (i == 5)
                {
                    continue;
                }
                Console.WriteLine(i);
            }
        }

        public void IfElseTest()
        {
            while (true)
            {
                Console.WriteLine("Enter Your exam mark out of 100");
                int mark = int.Parse(Console.ReadLine());
                if (mark > 80 && mark <= 100)
                {
                    Console.WriteLine("A Grade");
                    break;
                }
                else if (mark > 50 && mark <= 80)
                {
                    Console.WriteLine("B Grade");
                    break;
                }
                else if (mark < 0 || mark > 100)
                {
                    Console.WriteLine("Enter a valid mark");
                    continue;
                }
                else
                {
                    Console.WriteLine("You Failed");
                    break;
                }
            }
        }

        public void SwitchTest()
        {
            Console.WriteLine("Enter a number between 1 to 7");
            int day = int.Parse( Console.ReadLine());

            switch (day)
            {   
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;
                case 7:
                    Console.WriteLine("Sunday");
                    break;
                default:
                    Console.WriteLine("Invalid Day");
                    break;
            }
        }

        public void ForTest()
        {
            Console.WriteLine("For Loop\n");
            Console.WriteLine("Enter a number to print the pattern");
            int n = int.Parse( Console.ReadLine());
            for(int i = 1; i <= n; i++)
            {
                for(int j = n; j >= i; j--)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }

        public void WhileTest()
        {
            Console.WriteLine("While Loop\n");
            Console.WriteLine("Enter a number to print the pattern");
            int n = int.Parse(Console.ReadLine());
            int i = 1;
            while (i <= n)
            {
                int j = 1;
                while (j <= i)
                {
                    Console.Write("* ");
                    j++;
                }
                Console.WriteLine();
                i++;
            }
        }

        public void DoWHileTest()
        {
            Console.WriteLine("Do While Loop\n");
            int i = 1;
            bool run = i < 0;
            do
            {
                Console.WriteLine($"Executed even when i = {i} but the condition is (i < 0) ");
                i++;
            } while (run);
        }

        public void ForEachTest()
        {
            Console.WriteLine("For Each\n");
            string[] arr = { "apple", "orange", "mango" };
            foreach(string any in arr)
            {
                Console.WriteLine(any);
            }
        }
    }
}