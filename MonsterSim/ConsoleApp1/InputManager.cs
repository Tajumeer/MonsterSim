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
        public void ChooseMonster()
        {
            ConsoleKey temp = Console.ReadKey(true).Key;
            Console.WriteLine("Choose the first Monster.\nPress 1 to Choose an Orc\nPress 2 to Choose an Troll\nPress 3 to Choose an Goblin");
            switch (temp)
            {
                case ConsoleKey.D1:
                    
                    break;
            }
        }

        public void SetupOrc(Combat CombatObj)
        {
            float orcHp;
            float orcAp;
            float orcDp;
            float orcS;
            Console.WriteLine("Set the Orcs Healthpoints");
            float.TryParse(Console.ReadLine(), out orcHp);
            Console.WriteLine("Set the Orcs Attackpoints");
            float.TryParse(Console.ReadLine(), out orcAp);
            Console.WriteLine("Set the Orcs Defensepoints");
            float.TryParse(Console.ReadLine(), out orcDp);
            Console.WriteLine("Set the Orcs Speed");
            float.TryParse(Console.ReadLine(), out orcS);
            Orc OrcObj = new Orc(orcHp, orcAp, orcDp, orcS);
            CombatObj.ListOfMonsters.Add(OrcObj);
        }
    }
}
