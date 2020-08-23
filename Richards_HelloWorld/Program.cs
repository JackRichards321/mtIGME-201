using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Richards_HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Stephen Jack Richards");

            int num1 = 6;
            int num2 = 9;
            Console.WriteLine(num1);
            Console.WriteLine("6 + 9 = " + num1 + num2); // concatenates, does not add
            Console.WriteLine("6 + 9 = " + (num1 + num2)); // needs parentheses

            for (int j = 0; j < 15; j++)
            {
                Console.WriteLine(j);
                Console.WriteLine(j + " times 5 equals " + (j * 5));
            }
        }
    }
}
