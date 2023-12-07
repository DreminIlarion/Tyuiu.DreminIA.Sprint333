using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.DreminIa.Sprint3.Task1.V24.Lib;


namespace Tyuiu.DreminIa.Sprint3.Task1.V24
{
	internal class Program
	{
		static void Main(string[] args)
		{
			DataService ds = new DataService();
			Console.Title = "Спринт #3 | Выполнил:  Дремин И А | АсоИуб 23-3";
			Console.WriteLine("******************************************************************************");
			Console.WriteLine("* Спринт #3                                                                  *");
			Console.WriteLine("* Тема: Оператор цикла while                                                 *");
			Console.WriteLine("* Задание #1                                                                 *");
			Console.WriteLine("* Вариант #24                                                                *");
			Console.WriteLine("* Выполнил:  Дремин И А | АсоИуб 23-3                                 *");
			Console.WriteLine("******************************************************************************");
			Console.WriteLine("* УСЛОВИЕ:                                                                   *");
			Console.WriteLine("* Написать программу используя цикл while, которая вычисляет сумму ряда по   *");
			Console.WriteLine("*                                    формуле при х = 5                       *");
			Console.WriteLine("******************************************************************************");
			Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                           *");
			Console.WriteLine("******************************************************************************");

			int value = 5;
			int StartValue = 1;
			int StopValue = 12;

			Console.WriteLine("Переменная х = " + value);
			Console.WriteLine("StartValue = " + StartValue);
			Console.WriteLine("StopValue = " + StopValue);


			Console.WriteLine("******************************************************************************");
			Console.WriteLine("* РЕЗУЛЬТАТ:                                                                 *");
			Console.WriteLine("******************************************************************************");

			Console.WriteLine("Сумма ряда равна: " + ds.GetSumSeries(value, StartValue, StopValue));
			Console.ReadKey();
		}
	}
}