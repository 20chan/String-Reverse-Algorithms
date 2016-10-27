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
            while (true)
                Console.WriteLine(Reverses.Yield(Console.ReadLine()));
        }
    }
}
