using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp1
{
	public static class GameDialog
	{
		
		public static Hero Start()
		{
			Console.CursorTop = 8;
			Console.CursorLeft = 0;
			Console.WriteLine("Чтобы начать давай сначала решим как будут звать нашего героя.\n"+ "Введи имя персонажа.");
			string HeroName = Console.ReadLine();
			CleanDialog();
			return (new Hero(HeroName));
		}

		public static void Learn(Hero hero)
		{
			Enemy enemy = new Enemy();
			string a;
			Battle Battle1 = new Battle();
			CleanDialog();
			Console.CursorTop = 7;
			Console.CursorLeft = 0;
			Console.WriteLine("Здравствуй, "+ hero.Name+"!\n"+
				"Теперь ты готов совершать подвиги! Но сначала потренируемся на скелете! Напиши 'Ударить' чтобы нанести урон противнику!\nА если ты хочешь восстановить свое здоровье, напиши 'Лечиться'! Вперед!");
			Console.WriteLine("Ударить или лечиться?\n");
			enemy.EnemyStats(hero.Level);
			EnemyStats(enemy);
			while (enemy.HealthNow != 0)
			{
				a = Console.ReadLine();
				if (a.Equals("Ударить"))
				{
                    Battle1.BattleGround();
					Battle1.Fight(hero, enemy);
					EnemyStats(enemy);
					HeroStats(hero);

					
				}
				CleanDialog();
				Console.CursorTop = 7;
				Console.CursorLeft = 0;
				Console.WriteLine("Здравствуй, " + hero.Name + "!\n" +
				                  "Теперь ты готов совершать подвиги! Но сначала потренируемся на скелете! Напиши 'Ударить' чтобы нанести урон противнику!\nА если ты хочешь восстановить свое здоровье, напиши 'Лечиться'! Вперед!\n");
				Console.WriteLine("Ударить или лечиться?\n");
                if(enemy.HealthNow <= 0)
                {
                    //Console.WriteLine("Победа!Ура!");
                    Battle1.EnemyDown();
                    hero.ExpNow = hero.ExpNow + 10;
                    hero.Coins = hero.Coins+ 10;
                    hero.LvlUp();
                    HeroStats(hero);
                    break;
                }
                
                

            }
            CleanDialog();
            ClearEnemyStats();
            Console.CursorTop = 7;
            Console.CursorLeft = 0;
            Console.WriteLine("Ура! Победа! Ура!");


        }

		public static void CleanDialog()
        { 
            Console.CursorTop = 7;
            Console.CursorLeft = 0;
            Console.WriteLine("                                                                                                                                                                                                                                         ");
            Console.CursorTop = 8;
            Console.CursorLeft = 0;
            Console.WriteLine("                                                                                                                                                                                                                                                  ");
            Console.CursorTop = 9;
            Console.CursorLeft = 0;
            Console.WriteLine("                                                                                                                                                                                                                                                      ");
            Console.CursorTop = 10;
            Console.CursorLeft = 0;
            Console.WriteLine("                                                                                                                                                                                                                                                      ");
            Console.CursorTop = 11;
            Console.CursorLeft = 0;
            Console.WriteLine("                                                                                                                                                                                                                                                      ");
            Console.CursorTop = 12;
            Console.CursorLeft = 0;
            Console.WriteLine("                                                                                                                                                                                                                                                      ");

        }

		public static void EnemyStats(Enemy enemy)
		{
			Console.CursorTop = 0;
			Console.CursorLeft = 56;
			//Console.ReadKey();
			Console.ForegroundColor = ConsoleColor.Red;
			Console.WriteLine("****************************************************************");
			Console.CursorTop = 1;
			Console.CursorLeft = 56;
			Console.WriteLine("*                                                              *");
			Console.CursorTop = 2;
			Console.CursorLeft = 56;
			Console.WriteLine("*                                                              *");
			Console.CursorTop = 3;
			Console.CursorLeft = 56;
			Console.WriteLine("*                                                              *");
			Console.CursorTop = 4;
			Console.CursorLeft = 56;
			Console.WriteLine("*                                                              *");
			Console.CursorTop = 5;
			Console.CursorLeft = 56;
			Console.WriteLine("****************************************************************");
			Console.ResetColor();
			Console.CursorTop = 1;
			Console.CursorLeft = 57;
			Console.WriteLine("Имя противника: " + enemy.Name + ".");
			Console.CursorTop = 2;
			Console.CursorLeft = 57;
			Console.WriteLine("Здоровье: " + enemy.HealthNow + "/" + enemy.Health + ".");
			Console.CursorTop = 3;
			Console.CursorLeft = 57;
			Console.WriteLine("Мана: " + enemy.ManaNow + "/" + enemy.Mana + ".");
			Console.CursorTop = 4;
			Console.CursorLeft = 57;
			Console.WriteLine("Уровень: " + enemy.Level + ".");
			Console.CursorTop = 11;
			Console.CursorLeft = 0;
		}

		public static void HeroStats(Hero hero)
		{
			Console.CursorTop = 0;
			Console.CursorLeft = 0;
			Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("********************************************************\n" +
                              "*                                                      *\n" +
                              "*                                                      *\n" +
                              "*                                                      *\n" +
                              "*                                                      *\n" +
                              "*                                                      *\n"+
                              "********************************************************");
			Console.ResetColor();
			Console.CursorTop = 1;
			Console.CursorLeft = 2;
			Console.WriteLine("Имя персонажа: " + hero.Name + ".");
			Console.CursorTop = 2;
			Console.CursorLeft = 2;
			Console.WriteLine("Здоровье: " + hero.HealthNow + "/" + hero.Health + ".");
			Console.CursorTop = 3;
			Console.CursorLeft = 2;
			Console.WriteLine("Мана: " + hero.ManaNow + "/" + hero.Mana + ".");
			Console.CursorTop = 4;
			Console.CursorLeft = 2;
			Console.WriteLine("Уровень: " + hero.Level + ".");
			Console.CursorTop = 5;
			Console.CursorLeft = 2;
			Console.WriteLine("Опыт: " + hero.ExpNow + "/" + hero.Exp + ".\n");
		}
        public static void ClearEnemyStats()
        {
            Console.CursorTop = 0;
            Console.CursorLeft = 56;
            //Console.ReadKey();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("****************************************************************");
            Console.CursorTop = 1;
            Console.CursorLeft = 56;
            Console.WriteLine("*                                                              *");
            Console.CursorTop = 2;
            Console.CursorLeft = 56;
            Console.WriteLine("*                                                              *");
            Console.CursorTop = 3;
            Console.CursorLeft = 56;
            Console.WriteLine("*                                                              *");
            Console.CursorTop = 4;
            Console.CursorLeft = 56;
            Console.WriteLine("*                                                              *");
            Console.CursorTop = 5;
            Console.CursorLeft = 56;
            Console.WriteLine("****************************************************************");
            Console.ResetColor();
            Console.CursorTop = 1;
            Console.CursorLeft = 57;
            Console.WriteLine("                                                       ");
            Console.CursorTop = 2;
            Console.CursorLeft = 57;
            Console.WriteLine("                                                       ");
            Console.CursorTop = 3;
            Console.CursorLeft = 57;
            Console.WriteLine("                                                       ");
            Console.CursorTop = 4;
            Console.CursorLeft = 57;
            Console.WriteLine("                                                       ");
            Console.CursorTop = 11;
            Console.CursorLeft = 0;
        }
	}
}
