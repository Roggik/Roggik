using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
	public class Enemy
	{
		public int Health;
		public int HealthNow;
		public int Mana;
		public int ManaNow;
		public int DefaultMagicDamage;
		public int Level;
		public string Name;

		public void EnemyStats(int lvl)
		{
			Random rnd = new Random();
			switch (lvl)
			{
				case 1: Health = 50;
						HealthNow = Health;
						Mana = 15;
						ManaNow = Mana;
						DefaultMagicDamage = 0;
						Level = 1;
						Name = "Проклятый скелет";
					break;
			}
		}
	}
	
}
