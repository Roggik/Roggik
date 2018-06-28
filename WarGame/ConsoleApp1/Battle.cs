using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ConsoleApp1
{
	public class Battle
	{
		//Enemy enemy = new Enemy();
		public void Damage(Hero hero, Enemy enemy)
		{
			Random rnd = new Random();
			switch (hero.Level)
			{
				case 1:
					hero.DefaultMagicDamage = rnd.Next(0,20);
					enemy.DefaultMagicDamage = rnd.Next(0, 20);
					
					break;
				case 2:
					hero.DefaultMagicDamage = 4;
					break;
			}

		}
		public void Fight(Hero hero, Enemy enemy)
		{
			Damage(hero, enemy);
            FireBallFromHero();
			DamageOnEnemy(hero);
            enemy.HealthNow = enemy.HealthNow - hero.DefaultMagicDamage;
			FireballAirFromEnemy();
			DamageOnHero(enemy);
			hero.HealthNow = hero.HealthNow - enemy.DefaultMagicDamage;
		}

		public void DamageOnEnemy(Hero hero)
		{
			Console.CursorTop = 19;
			Console.CursorLeft = 44;
			Console.ForegroundColor = ConsoleColor.Red;
			Console.WriteLine("-"+ hero.DefaultMagicDamage);
			Thread.Sleep(300);
			Console.CursorTop = 19;
			Console.CursorLeft = 44;
			Console.WriteLine("      ");
		}

		public void DamageOnHero(Enemy enemy)
		{
			Console.CursorTop = 19;
			Console.CursorLeft = 0;
			Console.ForegroundColor = ConsoleColor.Red;
			Console.WriteLine("-" + enemy.DefaultMagicDamage);
			Thread.Sleep(300);
			Console.CursorTop = 19;
			Console.CursorLeft = 0;
			Console.WriteLine("      ");

		}
        public void BattleGround()
        {
            Console.CursorTop = 25;
            Console.CursorLeft = 0;
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("***********************************************");
            Console.WriteLine("***********************************************");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.CursorTop = 20;
            Console.CursorLeft = 0;
            Console.WriteLine("--");
            Console.CursorTop = 21;
            Console.CursorLeft = 0;
            Console.WriteLine("---");
            Console.CursorTop = 22;
            Console.CursorLeft = 0;
            Console.WriteLine("[ ]/|");
            Console.CursorTop = 23;
            Console.CursorLeft = 0;
            Console.WriteLine("---");
            Console.CursorTop = 24;
            Console.CursorLeft = 0;
            Console.WriteLine("| |");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.CursorTop = 20;
            Console.CursorLeft = 44;
            Console.WriteLine("--");
            Console.CursorTop = 21;
            Console.CursorLeft = 44;
            Console.WriteLine("---");
            Console.CursorTop = 22;
            Console.CursorLeft = 42;
            Console.WriteLine("|-[ ]");
            Console.CursorTop = 23;
            Console.CursorLeft = 44;
            Console.WriteLine("---");
            Console.CursorTop = 24;
            Console.CursorLeft = 44;
            Console.WriteLine("| |");
        }
        public void FireballAirFromEnemy()
        {
            Console.CursorTop = 22;
            Console.CursorLeft = 5;
            Console.WriteLine("                                    #");
            Thread.Sleep(250);
            Console.CursorTop = 22;
            Console.CursorLeft = 5;
            Console.WriteLine("                                   # ");
            Thread.Sleep(250);
            Console.CursorTop = 22;
            Console.CursorLeft = 5;
            Console.WriteLine("                                  #  ");
            Thread.Sleep(250);
            Console.CursorTop = 22;
            Console.CursorLeft = 5;
            Console.WriteLine("                                 #   ");
            Thread.Sleep(250);
            Console.CursorTop = 22;
            Console.CursorLeft = 5;
            Console.WriteLine("                                #    ");
            Thread.Sleep(250);
            Console.CursorTop = 22;
            Console.CursorLeft = 5;
            Console.WriteLine("                               #     ");
            Thread.Sleep(250);
            Console.CursorTop = 22;
            Console.CursorLeft = 5;
            Console.WriteLine("                             #       ");
            Thread.Sleep(250);
            Console.CursorTop = 22;
            Console.CursorLeft = 5;
            Console.WriteLine("                           #         ");
            Thread.Sleep(250);
            Console.CursorTop = 22;
            Console.CursorLeft = 5;
            Console.WriteLine("                        #            ");
            Thread.Sleep(250);
            Console.CursorTop = 22;
            Console.CursorLeft = 5;
            Console.WriteLine("                      #              ");
            Thread.Sleep(250);
            Console.CursorTop = 22;
            Console.CursorLeft = 5;
            Console.WriteLine("                   #                 ");
            Thread.Sleep(250);
            Console.CursorTop = 22;
            Console.CursorLeft = 5;
            Console.WriteLine("                 #                   ");
            Thread.Sleep(250);
            Console.CursorTop = 22;
            Console.CursorLeft = 5;
            Console.WriteLine("              #                      ");
            Thread.Sleep(250);
            Console.CursorTop = 22;
            Console.CursorLeft = 5;
            Console.WriteLine("           #                         ");
            Thread.Sleep(250);
            Console.CursorTop = 22;
            Console.CursorLeft = 5;
            Console.WriteLine("         #                           ");
            Thread.Sleep(250);
            Console.CursorTop = 22;
            Console.CursorLeft = 5;
            Console.WriteLine("      #                              ");
            Thread.Sleep(250);
            Console.CursorTop = 22;
            Console.CursorLeft = 5;
            Console.WriteLine("   #                                 ");
            Thread.Sleep(250);
            Console.CursorTop = 22;
            Console.CursorLeft = 5;
            Console.WriteLine(" #                                   ");
            Thread.Sleep(250);
            Console.CursorTop = 22;
            Console.CursorLeft = 5;
            Console.WriteLine("                                     ");

        }

		public void FireBallFromHero()
		{
			Console.ForegroundColor = ConsoleColor.Green;
			Console.CursorTop = 22;
			Console.CursorLeft = 5;
			Console.WriteLine("#                                    ");
			Thread.Sleep(250);
			Console.CursorTop = 22;
			Console.CursorLeft = 5;
			Console.WriteLine(" #                                   ");
			Thread.Sleep(250);
			Console.CursorTop = 22;
			Console.CursorLeft = 5;
			Console.WriteLine("  #                                  ");
			Thread.Sleep(250);
			Console.CursorTop = 22;
			Console.CursorLeft = 5;
			Console.WriteLine("   #                                 ");
			Thread.Sleep(250);
			Console.CursorTop = 22;
			Console.CursorLeft = 5;
			Console.WriteLine("     #                               ");
			Thread.Sleep(250);
			Console.CursorTop = 22;
			Console.CursorLeft = 5;
			Console.WriteLine("       #                             ");
			Thread.Sleep(250);
			Console.CursorTop = 22;
			Console.CursorLeft = 5;
			Console.WriteLine("          #                          ");
			Thread.Sleep(250);
			Console.CursorTop = 22;
			Console.CursorLeft = 5;
			Console.WriteLine("             #                       ");
			Thread.Sleep(250);
			Console.CursorTop = 22;
			Console.CursorLeft = 5;
			Console.WriteLine("                #                    ");
			Thread.Sleep(250);
			Console.CursorTop = 22;
			Console.CursorLeft = 5;
			Console.WriteLine("                   #                 ");
			Thread.Sleep(250);
			Console.CursorTop = 22;
			Console.CursorLeft = 5;
			Console.WriteLine("                       #             ");
			Thread.Sleep(250);
			Console.CursorTop = 22;
			Console.CursorLeft = 5;
			Console.WriteLine("                           #         ");
			Thread.Sleep(250);
			Console.CursorTop = 22;
			Console.CursorLeft = 5;
			Console.WriteLine("                             #       ");
			Thread.Sleep(250);
			Console.CursorTop = 22;
			Console.CursorLeft = 5;
			Console.WriteLine("                               #     ");
			Thread.Sleep(250);
			Console.CursorTop = 22;
			Console.CursorLeft = 5;
			Console.WriteLine("                                 #   ");
			Thread.Sleep(250);
			Console.CursorTop = 22;
			Console.CursorLeft = 5;
			Console.WriteLine("                                  #  ");
			Thread.Sleep(250);
			Console.CursorTop = 22;
			Console.CursorLeft = 5;
			Console.WriteLine("                                   # ");
			Thread.Sleep(250);
			Console.CursorTop = 22;
			Console.CursorLeft = 5;
			Console.WriteLine("                                    #");
			Thread.Sleep(250);
			Console.CursorTop = 22;
			Console.CursorLeft = 5;
			Console.WriteLine("                                     ");
		}

        public void EnemyDown()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.CursorTop = 20;
            Console.CursorLeft = 44;
            Console.WriteLine("  ");
            Console.CursorTop = 21;
            Console.CursorLeft = 44;
            Console.WriteLine("   ");
            Console.CursorTop = 22;
            Console.CursorLeft = 42;
            Console.WriteLine("     ");
            Console.CursorTop = 23;
            Console.CursorLeft = 44;
            Console.WriteLine("   ");
            Console.CursorTop = 24;
            Console.CursorLeft = 44;
            Console.WriteLine("   ");
            Console.CursorTop = 22;
            Console.CursorLeft = 45;
            Console.WriteLine("|");
            Console.CursorTop = 23;
            Console.CursorLeft = 44;
            Console.WriteLine("---");
            Console.CursorTop = 24;
            Console.CursorLeft = 45;
            Console.WriteLine("| ");
        }
	}
}
