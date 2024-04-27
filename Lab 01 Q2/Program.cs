using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_01_Q2
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Enter number {i + 1}:");
                int number = Convert.ToInt32(Console.ReadLine());

                if (IsEven(number))
                {
                    Console.WriteLine("Even");
                }
                else
                {
                    Console.WriteLine("Odd");
                }
            }
        }

        static bool IsEven(int number)
        {
            return number % 2 == 0;
        }
    }
}



