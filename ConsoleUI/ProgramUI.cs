using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pair_Programming_Console_Game.ConsoleUI
{
    class ProgramUI
    {

    }

    public void Run()
    {
        EasyWordList();
        GameMenu();
    }

    private void GameMenu()
    {
        bool continueToRun = true;
        while (continueToRun)
        {
            Console.Clear();
            Console.WriteLine(
                "1. Start Game? \n" +
                "2. Ready for next round? \n" +
                "3. Take in char from user(alternate)" +
                "4. Guess Correct phrase/word" +
                "5. Exit Game");
                

            //1.Start game?
            //2. Ready for next round?
            //3. Take in char from user(alternating)
            //4. if user selects they would like to guess(true), use (3), if false, run (2)
            //Exit Game

            string userInput = Console.ReadLine();
        }
    }
}
