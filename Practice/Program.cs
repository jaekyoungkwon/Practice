using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
             for (i=2;i<=9;i++)
             {
                for (int j = 1; j <= 9; j++)
                    Console.WriteLine($"{i} x {j} = {i * j}");
                    Console.WriteLine("");
             }
             Console.WriteLine("w");
        }
    }
}
