using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salary_Struct
{
    class Program
    {
        static void Main(string[] args)
        {
            string sName;
            double dSalary = 30000;

            Console.WriteLine("What is your name? ");
            sName = Console.ReadLine();

            if (GiveRaise(sName, ref dSalary))
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

        struct Employee
        {
            public string sName;
            public double dSalary;

            public static bool giveRaise(Employee emp)
            {
                if (emp.sName.ToLower() == "jack")
                {
                    emp.dSalary += 19999;
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
    }
}
