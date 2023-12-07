using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.DreminIa.Sprint3.Task3.V22.Lib;

namespace Tyuiu.DreminIa.Sprint3.Task3.V22
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #3 | Выполнил:  Дремин И А | АсоИуб 23-3";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("*Тема: Создания итогового решения по спринту                              *");
            Console.WriteLine("*Задание #Task3                                                           *");
            Console.WriteLine("*Вариант #22                                                              *");
            Console.WriteLine("*Выполнил:  Дремин И А | АсоИуб 23-3                    *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*УСЛОВИЕ:                                                                 *");
            Console.WriteLine("* Написать программу, которая подсчитает максимальное количество букв b    ");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("*                                                                         *");

            // Место решения задания
            DataService service1 = new DataService();


            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");


            string x = "tbtbbb dsfbg bbg";
            char y = 'b';



            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            int res = service1.GetMaxCharCount(x, y);

            Console.WriteLine("Кол-во букав 'b' = " + res);


            Console.ReadKey();
        }
    }
}