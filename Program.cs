using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Write a");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Write b");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Write z");
            int z = Convert.ToInt32(Console.ReadLine());
            Console.Write("Write x");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"c=({a}+{b})*11*{z}-12*{x}");
            double c=(a + b) * 11 * z - 12 * x;
            Console.WriteLine("c={0}", c.ToString());
            ConsoleKeyInfo nupp = new ConsoleKeyInfo();
            do
            {
                Console.WriteLine("Vajuta Backspace");
                nupp = Console.ReadKey();

            } while (nupp.Key != ConsoleKey.Backspace);






        }
    }
}
