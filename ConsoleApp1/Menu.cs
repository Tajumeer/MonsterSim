using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace MonsterSim
{
    /// <summary>
    /// this Class contains all menu structures
    /// </summary>    
    internal class Menu
    {
        /// <summary>
        /// Main menu asking for user input to continue or exit the game
        /// </summary>
        /// <param name="signs"></param>
        /// <param name="input"></param>
        /// <param name="game"></param>
        public void MainMenu(InputManager input, GameManager game, Ascii ascii)
        {
            Console.WriteLine(ascii.SmorcText);
            Console.WriteLine("Welcome to SMORC.\nPress [Y] to continue or [N] to Exit.\n");
            while (true)
            {
                if (input.IsContinueOrExitKey())
                {
                    Console.Clear();
                    Console.WriteLine(ascii.SmorcText);
                    Console.WriteLine("SMORC is a Monster Battle Arena.\nTo play SMORC, you need to choose 2 Combatants and give them Combatstats to let them fight to the Death!");
                    Console.WriteLine("Press any to continue.\n");
                    Console.ReadKey(true);
                    break;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine();
                    Environment.Exit(0);

                }
            }
        }

        /// <summary>
        /// Menu after you beat the game asking for user input to enter the game loop or exit the game
        /// </summary>
        /// <param name="signs"></param>
        /// <param name="input"></param>
        /// <param name="menu"></param>
        /// <param name="game"></param>
        /// <param name="room"></param>
        /// <param name="pl"></param>
        public void EndMenu(InputManager input, GameManager game, Ascii ascii)
        {
            Console.WriteLine(ascii.SmorcHead);
            Console.WriteLine("If you want to play again press [Y] if you want to exit the game press [N]");
            while (true)
            {
                if (input.IsContinueOrExitKey())
                {
                    //game.IsGame = true;
                    game.GameInit();
                    break;
                }
                else
                {
                    Environment.Exit(0);
                }

            }
        }
    }
}
