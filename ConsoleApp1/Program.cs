using System;
namespace Inl_uppgift_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hur många heltal kommer du skriva?");
            int x = Convert.ToInt32(Console.ReadLine());

            int[] y = new int[x];

            Console.WriteLine("Skriv in " + x + " heltal.");

            for (int i = 0; i < x; i++)
            {
                y[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Du skrev talen i denna ordning:");

            for (int i = 0; i < x; i++)
            {
                Console.WriteLine("Tal " + (i + 1) + ": " + y[i]);
            }
        }
    }
}