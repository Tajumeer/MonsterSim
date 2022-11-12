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
            GameManager GameManagerObj = new GameManager();
            Combat CombatObj = new Combat();
            Menu MenuObj = new Menu();
            Ascii AsciiObj = new Ascii();
            Console.CursorVisible = false;
            MenuObj.MainMenu(InputManagerObj, GameManagerObj, AsciiObj);
            InputManagerObj.ChooseMonster(CombatObj);
            Gameplay(CombatObj, CombatObj.ListOfMonsters[0], CombatObj.ListOfMonsters[1],MenuObj, InputManagerObj, GameManagerObj, AsciiObj);
        }

        public void Gameplay(Combat combat, Monster monster1, Monster monster2, Menu menu, InputManager input, GameManager game, Ascii ascii)
        {
            combat.MonsterFight(monster1, monster2);
            menu.EndMenu(input, game, ascii);
        }

 
    }
}
