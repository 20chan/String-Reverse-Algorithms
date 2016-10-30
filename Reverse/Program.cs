using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Reverse
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();
            sw.Start();
            string original = "this is reversed";
            string reversed = "desrever si siht";
            Random rnd = new Random();
            while (true)
            {
                var randomized = string.Concat(reversed.OrderBy(x => rnd.Next()));
                Console.WriteLine(randomized);
                if (reversed == randomized)
                {
                    Console.WriteLine("Clear!!");
                    sw.Stop();
                    Console.WriteLine("경과된 시간 : " + sw.ElapsedMilliseconds + "ms");
                }
            }
        }
    }
}
