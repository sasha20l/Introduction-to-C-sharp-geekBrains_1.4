using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfNumbers
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine($"Сумма чисел = {InputNumbers()}");
            Console.ReadLine();
        }
    
        static int InputNumbers()
        {
            while (true)
            {
                Console.WriteLine("Введите набор чисел, разделенных пробелом, для их суммы");

                try
                {
                    string[] split = Console.ReadLine().Split(new Char[] { ' ' });
                    int SumOfNumbers = 0;
                    foreach (string nums in split)
                    {
                        SumOfNumbers += int.Parse(nums);
                    }
                    return SumOfNumbers;
                }
                catch
                {
                }
            }
        }
    }
}
