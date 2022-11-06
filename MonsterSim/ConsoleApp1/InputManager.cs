using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterSim
{
    internal class InputManager
    {
        public void ChooseMonster(Combat CombatObj)
        {
            Console.WriteLine("Choose the first Monster.\nPress 1 to Choose an Orc\nPress 2 to Choose an Troll\nPress 3 to Choose an Goblin");
            ConsoleKey temp = Console.ReadKey(true).Key;
            switch (temp)
            {
                case ConsoleKey.D1:
                    Monster OrcObj = new Monster(1);
                    CombatObj.ListOfMonsters.Add(OrcObj);
                    break;
                case ConsoleKey.D2:
                    Monster TrollObj = new Monster(2);
                    CombatObj.ListOfMonsters.Add(TrollObj);
                    break;
                case ConsoleKey.D3:               
                    Monster GoblinObj = new Monster(3);
                    CombatObj.ListOfMonsters.Add(GoblinObj);
                    break;
            }
        }
    }
}
