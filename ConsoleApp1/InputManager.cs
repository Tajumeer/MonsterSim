using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterSim
{
    /// <summary>
    /// this class handles User Inputs
    /// </summary>
    internal class InputManager
    {

        /// <summary>
        /// This function lets you choose your Monsters
        /// </summary>
        /// <param name="CombatObj"></param>
        public void ChooseMonster(Combat CombatObj)
        {
            int firstMonster = 0;
            int monsterAmount = 0;
            Console.Clear();
            Console.WriteLine("Choose the first Monster.\nPress 1 to Choose an Orc\nPress 2 to Choose an Troll\nPress 3 to Choose an Goblin");
            while (monsterAmount < 2)
            {
            ConsoleKey temp = Console.ReadKey(true).Key;
                if (monsterAmount == 1)
                {
                    Console.Clear();
                    Console.WriteLine("--------------------");
                    Console.WriteLine("Choose the second Monster.\nPress 1 to Choose an Orc\nPress 2 to Choose an Troll\nPress 3 to Choose an Goblin\nMonsters of the same Race cant fight amongst each other!");
                }
                switch (temp)
                {
                    case ConsoleKey.D1:
                        if (firstMonster == 1)
                        {
                            ErrorChooseMonster();
                            continue;
                        }
                        else
                        {
                            firstMonster = 1;
                            monsterAmount++;
                            Monster OrcObj = new Monster(1);
                            CombatObj.ListOfMonsters.Add(OrcObj);
                            continue;
                        }
                    case ConsoleKey.D2:
                        if (firstMonster == 2)
                        {
                            ErrorChooseMonster();
                            continue;
                        }
                        else
                        {
                            firstMonster = 2;
                            monsterAmount++;
                            Monster TrollObj = new Monster(2);
                            CombatObj.ListOfMonsters.Add(TrollObj);
                            continue;
                        }
                    case ConsoleKey.D3:
                        if (firstMonster == 3)
                        {
                            ErrorChooseMonster();
                            continue;
                        }
                        else
                        {
                            firstMonster = 3;
                            monsterAmount++;
                            Monster GoblinObj = new Monster(3);
                            CombatObj.ListOfMonsters.Add(GoblinObj);
                            continue;
                        }
                    default:
                        Console.WriteLine("default");
                        continue;
                }

            }
            Console.Clear();
        }

        /// <summary>
        /// This Error checks if the Monsters Race is Different
        /// </summary>
        public void ErrorChooseMonster()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Monster's of the same Race cant fight amongst each other.\nPlease choose another Race.");
            Console.ResetColor();
            Console.WriteLine("Choose the second Monster.\nPress 1 to Choose an Orc\nPress 2 to Choose an Troll\nPress 3 to Choose an Goblin");
        }

        /// <summary>
        /// checks if the input was continue or exit or something else
        /// </summary>
        /// <returns></returns>
        public bool IsContinueOrExitKey()
        {
            ConsoleKey temp = Console.ReadKey(true).Key;

            switch (temp)
            {
                case ConsoleKey.Y:
                    return true;
                case ConsoleKey.N:
                    return false;
                default:
                    Console.WriteLine("Please press [Y] to continue or [N] to exit");
                    IsContinueOrExitKey();
                    break;
            }
            return true;
        }
    }
}
