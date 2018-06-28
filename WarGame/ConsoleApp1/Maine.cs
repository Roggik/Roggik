using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
	public class Maine
	{
		public static void Main(string[] args)
		{
			Hero MainHero = GameDialog.Start();
			GameDialog.HeroStats(MainHero);
			//Выводим характеристики
			GameDialog.Learn(MainHero);
			Console.ReadKey();





		}


	}
}
