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
            InputManagerObj.SetupOrc(CombatObj);

            foreach (var Object in CombatObj.ListOfMonsters)
            {
                Console.WriteLine(Object.ToString());
            }




        }
    }
}
