using System;

namespace OpenLab_02._4_vlastne
{
    class Program
    {
        public static int legsCount(int chickens, int cows, int pigs)
        {
            int count = ((chickens * 2) + (cows * 4) + (pigs * 4));
            return count;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("počet chickens :");
            var input = Console.ReadLine();
            Console.WriteLine("počet cows :");
            var input2 = Console.ReadLine();
            Console.WriteLine("počet pigs :");
            var input3 = Console.ReadLine();
            int chickens  = Int32.Parse(input);
            int cows = Int32.Parse(input2);
            int pigs = Int32.Parse(input3);
            int count = legsCount(chickens, cows, pigs);
            Console.WriteLine($"Súčet je {count}");
        }
    }
}
