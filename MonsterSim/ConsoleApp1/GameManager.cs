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
            Gameplay(CombatObj, CombatObj.ListOfMonsters[0], CombatObj.ListOfMonsters[1]);
        }

        public void Gameplay(Combat combat, Monster monster1, Monster monster2)
        {
            combat.MonsterFight(monster1, monster2);
        }
 
    }
}
