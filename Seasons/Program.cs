using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seasons
{
    class Program
    {
        enum Month { January, February, March, April, May, June, July, August, September, October, November, December };
        static void Main(string[] args)
        {
            Console.WriteLine(InputMonth(InputNumbers()));
            Console.ReadLine();
        }
        
        static string InputNumbers()
        {

            string[] numbers = new string[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12" };
            string inputNums = null;
            Console.WriteLine("Введите число от 1 до 12");
            do
            {   if (inputNums != null) Console.WriteLine("Ошибка: введите число от 1 до 12");
                inputNums = Console.ReadLine();
            }
            while (!numbers.Contains(inputNums));
            return ((Month)(int.Parse(inputNums)-1)).ToString();

        }
        static string InputMonth(string month)
        {
            string months = "";
            switch (month)
            {
                case "January":
                    months = "Январь";
                    break;
                case "February":
                    months = "Февраль";
                    break;
                case "March":
                    months = "Март";
                    break;
                case "April":
                    months = "Апрель";
                    break;
                case "May":
                    months = "Май";
                    break;
                case "June":
                    months = "Июнь";
                    break;
                case "July":
                    months = "Июль";
                    break;
                case "August":
                    months = "Август";
                    break;
                case "September":
                    months = "Сентябрь";
                    break;
                case "October":
                    months = "Октябрь";
                    break;
                case "November":
                    months = "Ноябрь";
                    break;
                case "December":
                    months = "Декабрь";
                    break;

            }
            return months;
        }

    }
}
