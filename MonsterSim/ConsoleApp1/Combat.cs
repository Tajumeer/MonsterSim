﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterSim
{
    public class Combat
    {
        public List<Monster> ListOfMonsters = new List<Monster>();

        public bool isSomeoneDead = false;
        Random rnd = new Random();
        public int rounds;
        public int SpeedCheck()

        {
            if (ListOfMonsters[0].Speed > ListOfMonsters[1].Speed) return 0;
            if (ListOfMonsters[1].Speed > ListOfMonsters[0].Speed) return 1;
            else
            {
                int prick = rnd.Next(0, 1);
                if (prick == 0) return 0;
                if (prick == 1) return 1;
            }
            return 0;
        }

        public void MonsterFight(Monster monster1, Monster monster2)
        {
            ListOfMonsters[0] = monster1;
            ListOfMonsters[1] = monster2;
            if (SpeedCheck() == 0)
            {
                while (!isSomeoneDead)
                {
                    rounds++;
                    monster1.DoDamage(monster1, monster2);
                    if (IsKilled(monster1, monster2, isSomeoneDead, rounds))
                        break;

                    monster2.DoDamage(monster2, monster1);

                    if (IsKilled(monster1, monster2, isSomeoneDead, rounds))
                        break;
                    isSomeoneDead = IsKilled(monster1, monster2, isSomeoneDead, rounds);
                    Console.WriteLine("Both Combatants survived this round press any key to start the next Round.");
                    Console.ReadKey(true);
                    Console.Clear();
                }

            }
            if (SpeedCheck() == 1)
            {
                while (!isSomeoneDead)
                {
                    rounds++;
                    monster2.DoDamage(monster2, monster1);
                    if (IsKilled(monster1, monster2, isSomeoneDead, rounds))
                        break;
                    monster1.DoDamage(monster1, monster2);
                    if (IsKilled(monster1, monster2, isSomeoneDead, rounds))
                        break;
                    isSomeoneDead = IsKilled(monster1, monster2, isSomeoneDead, rounds);
                    Console.WriteLine("Both Combatants survived this round press any key to start the next Round.");
                    Console.ReadKey(true);
                    Console.Clear();
                }
            }


        }

        private static bool IsKilled(Monster monster1, Monster monster2, bool isSomeoneDead, int rounds)
        {
            if (monster2.Health <= 0)
            {
                isSomeoneDead = true;
                Console.WriteLine("The {0} defeated the {1} in Combat after {2} rounds of Battle.", monster1.Race, monster2.Race, rounds);
            }
            if (monster1.Health <= 0)
            {
                isSomeoneDead = true;
                Console.WriteLine("The {0} defeated the {1} in Combat after {2} rounds of Battle..", monster2.Race, monster1.Race, rounds);
            }

            return isSomeoneDead;
        }
    }
}
