using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3Questions
{
    class Program
    {
        static void Main(string[] args)
        {
            string sName;
            double dSalary = 30000;

            Console.WriteLine("What is your name? ");
            sName = Console.ReadLine();

            if (GiveRaise(sName,  ref dSalary))
            {
                Console.WriteLine("Congratulations, you got a raise! Your new salary is " + dSalary);
            }
            else
            {
                Console.WriteLine("Unfortunately, we at JackCorp cannot give you a raise today. Try getting a better name!");
            }
        }

        static bool GiveRaise(string name, ref double salary)
        {
            if (name.ToLower() == "jack")
            {
                salary += 19999;
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
