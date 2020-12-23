using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace geekBrains1_4
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] getFullName = new string[3] { GetFullName("Иванов", "Иван", "Иванович"), GetFullName("Семенов", "Семен", "Семенович"), GetFullName("Путин", "Владимир", "Владимирович")};

            foreach (string name in getFullName)
            {
                Console.WriteLine(name);
            }
            Console.ReadLine();

        }


        static string GetFullName(string firstName, string lastName, string patronymic)
        {

            return $"{firstName} {lastName} {patronymic}";
        }
    }
}
