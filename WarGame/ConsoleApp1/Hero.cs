using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
	public class Hero
	{
		public int Health;
		public int HealthNow;
		public int Mana;
		public int ManaNow;
		public int MagicDamage;
		public int DefaultMagicDamage;
		public int Coins;
		public int Exp;
		public int ExpNow;
		public int Level;
		public string Name;
        

		public Hero(string name)
		{
			Health = 50;
			HealthNow = Health;
			Mana = 30;
			ManaNow = Mana;
			Level = 1;
			Name = name;
			ExpAll(Level);
		}


		public void ExpAll(int lvl)
		{
			
			switch (lvl)
			{
				case 1: Exp = 10;
					break;
				case 2: Exp = 20;
					break;
			}
			
		}
		public void LvlUp()
		{
            switch (ExpNow)
			{
				case 10: Level = 2;
                    ExpAll(Level);
					Health = Health + 10;
						 break;
				case 20: Level = 3;
                         ExpAll(Level);
						 break;
			}
		}

	}
}
