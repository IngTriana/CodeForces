using System;

namespace _581A
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] entrada = Console.ReadLine().Split(' ');
            int a = int.Parse(entrada[0]);
            int b = int.Parse(entrada[1]);

            if (a == b)
                Console.WriteLine(a + " 0");
            else if (a > b)
                Console.WriteLine(b + " " + ((a - b) / 2));
            else
                Console.WriteLine(a + " " + ((b - a) / 2));
        }
    }
}
