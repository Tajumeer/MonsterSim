using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterSim
{
    internal class GameManager
    {
        public void GameInit()
        {
            InputManager InputManagerObj = new InputManager();
            Combat CombatObj = new Combat();
            InputManagerObj.ChooseMonster(CombatObj);

            foreach (var Object in CombatObj.ListOfMonsters)
            {
                Console.WriteLine(Object.ToString());
            }




        }
    }
}
