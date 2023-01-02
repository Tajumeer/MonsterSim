using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterSim
{
    /// <summary>
    /// This class handles the correct Gameplay
    /// </summary>
    internal class GameManager
    {
        /// <summary>
        /// this function initializes the Game
        /// </summary>
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


        /// <summary>
        /// this class handles the Combat
        /// </summary>
        /// <param name="combat"></param>
        /// <param name="monster1"></param>
        /// <param name="monster2"></param>
        /// <param name="menu"></param>
        /// <param name="input"></param>
        /// <param name="game"></param>
        /// <param name="ascii"></param>
        public void Gameplay(Combat combat, Monster monster1, Monster monster2, Menu menu, InputManager input, GameManager game, Ascii ascii)
        {
            combat.MonsterFight(monster1, monster2);
            menu.EndMenu(input, game, ascii);
        }

 
    }
}
