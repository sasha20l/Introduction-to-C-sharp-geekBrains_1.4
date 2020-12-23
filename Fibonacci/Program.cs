using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int nums = int.Parse(Console.ReadLine());
            int[] array = new int[nums];
            for (int i = 0; i < nums; i++)
            {
                if (i == 0 || i == 1)
                {
                    array[i] = i;
                    continue;
                }
                array[i] = array[i - 1] + array[i - 2];
            }
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }

            Console.ReadLine();
        }
    }
}
