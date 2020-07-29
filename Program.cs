using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type your letters and press Enter");
            var inputLetters = Console.ReadKey();
            Console.WriteLine("here you go:", inputLetters);
        }
    }
}
