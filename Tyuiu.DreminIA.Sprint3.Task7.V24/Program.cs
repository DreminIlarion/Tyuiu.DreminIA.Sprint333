using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.DreminIa.Sprint3.Task7.V24.Lib;

namespace Tyuiu.DreminIa.Sprint3.Task7.V24
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();


            Console.Title = "Спринт #3 | Выполнил: Дремин И А | АсоИуб 23-3";
            //Длина строки 75 символов
            Console.WriteLine("****************************************************************************************");
            Console.WriteLine("* Спринт #3                                                                            *");
            Console.WriteLine("* Тема:  алгоритмы циклической структуры                                               *");
            Console.WriteLine("* Задание #7                                                                           *");
            Console.WriteLine("* Вариант #24                                                                          *");
            Console.WriteLine("* Выполнил:  Дремин И А | АсоИуб 23-3                                    *");
            Console.WriteLine("****************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                             *");
            Console.WriteLine("* Напишите программу, которая выводит таблицу значений функции                         *");
            Console.WriteLine("* F(x) = sin(x)/(x+1,2) - sin(x)*2 - 2x                                                *");
            Console.WriteLine("****************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                     *");
            Console.WriteLine("****************************************************************************************");


            int startValue = -5;
            int stopValue = 5;

            Console.WriteLine("Старт шага: " + startValue);
            Console.WriteLine("Стоп шага: " + stopValue);

            int len = ds.GetMassFunction(startValue, stopValue).Length;

            double[] arr = new double[len];

            arr = ds.GetMassFunction(startValue, stopValue);






            Console.WriteLine("****************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                           *");
            Console.WriteLine("****************************************************************************************");

            Console.WriteLine("+----------+----------+");
            Console.WriteLine("|    X     |    f(x)  |");
            Console.WriteLine("+----------+----------+");

            for (int i = 0; i <= len - 1; i++)
            {
                Console.WriteLine("|{0,5:d}     | {1,6:f2}   |", startValue, arr[i]);
                startValue++;
            }
            Console.WriteLine("+----------+----------+");
            Console.ReadLine();
        }
    }
}