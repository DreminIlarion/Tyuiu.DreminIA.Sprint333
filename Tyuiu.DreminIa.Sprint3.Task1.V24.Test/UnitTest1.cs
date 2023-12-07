using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.DreminIa.Sprint3.Task1.V24.Lib;

namespace Tyuiu.DreminIa.Sprint3.Task1.V24.Test
{
	[TestClass]
	public class DataServiceTest
	{
		[TestMethod]
		public void ValidGetSumSeries()
		{
			DataService ds = new DataService();

			int value = 5;
			int StartValue = 1;
			int StopValue = 12;

			double res = ds.GetSumSeries(value, StartValue, StopValue);

			double wait = 0.186;

			Assert.AreEqual(res, wait);
		}
	}
}