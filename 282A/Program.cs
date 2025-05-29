using System;

namespace _282A
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int x = 0;
            string V;
            for (int i = 0; i < n; i++)
            {
                V = Console.ReadLine();
                if(V == "++X" || V == "X++")
                {
                    x++;
                }
                else if (V == "--X" || V == "X--")
                {
                    x--;
                }
            }
            Console.WriteLine(x);
        }
    }
}
