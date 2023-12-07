﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.DreminIa.Sprint3.Task5.V27.Lib;

namespace Tyuiu.DreminIa.Sprint3.Task5.V27
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #3 | Выполнил:  Дремин И А | АсоИуб 23-3";
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("*Спринт 3                                                                  *");
            Console.WriteLine("*Тема: Вложенные циклы                                                     *");
            Console.WriteLine("*Задание #5                                                                *");
            Console.WriteLine("*Вариант #27                                                               *");
            Console.WriteLine("*Выполнил:  Дремин И А | АсоИуб 23-3                       *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("*УСЛОВИЕ:                                                                  *");
            Console.WriteLine("* Написать программу, которая вычисляет сумму ряда по формуле, при х=2     *");
            Console.WriteLine("*                                                                          *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("*ИСХОДНЫЕ ДАННЫЕ:                                                          *");
            Console.WriteLine("****************************************************************************");
            int x = 2;
            int startValue1 = 1;
            int stopValue1 = 3;
            int startValue2 = 1;
            int stopValue2 = 10;
            Console.WriteLine("Переменная X = " + x);
            Console.WriteLine("Старт шага первой суммы ряда = " + startValue1);
            Console.WriteLine("Конец шага первой суммы ряда = " + stopValue1);
            Console.WriteLine("Старт шага второй суммы ряда = " + startValue2);
            Console.WriteLine("Конец шага второй суммы ряда = " + stopValue2);

            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                               *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("Сумма сумм ряда = " + ds.GetSumSumSeries(x, startValue1, startValue2, stopValue1, stopValue2));
            Console.ReadLine();
        }
    }
}