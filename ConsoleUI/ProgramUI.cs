using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pair_Programming_Console_Game.ConsoleUI
{
    public class ProgramUI
    {
        // private readonly IConsole _console;
        // private readonly StreamingRepository _streamingRepo = new StreamingRepository();


        //public ProgramUI(IConsole console)
        //{
        //    _console = console;
        //}

        public void Run()
        {
            GameMenu();
        }

        private void GameMenu()
        {
            bool continueToRun = true;
            while (continueToRun)
            {
                Console.Clear();
                Console.Writeline(
                    "1. Start Game? \n" +
                    "2. Ready for next round? \n" +
                    "3. Take in char from user(alternate)" +
                    "4. Guess Correct phrase/word" +
                    "5. Exit Game");



                string playerInput = _console.Readline();
                // _console.WriteLine("Please enter 1 to start new game.");

                switch (playerInput)
                {
                    case "1":
                        StartGame();
                        break;
                    case "2":
                        ReadyForNextRound();
                        break;
                    case "3":
                        CharGuess();
                        break;
                    case "4":
                        AnswerGuess();
                    case "5":
                        continueToRun = false;
                        break;
                    default:
                        _console.WriteLine("Please enter 1 to start new game.");
                        _console.ReadKey();
                        break;

                }

                //start game
                private void StartGame();
                {
                    _console.Clear();

                    List<ListOfPhrasesOne> phrase = new ListOfPhrasesOne();

                    //have each difficulty denoted as 1-20(1),21-40(2),41-60(3)
                    //if this is causing problems, new up 3 different instances of list<phrase1>,2,3
                    //then have user select which list to choose from 
                    //if this does not work, create 3 enums for each (i.e. maturity rating) and below will allow user to randomly choose from certain enum
                    _console.WriteLine("Please enter the difficulty of game(1-3) 3 being the most challenging");
                    //from user input, randomly select a string from the list(or array of strings,enum)


                    phrase.RandomString = _console.ReadLine();
                    //now, display to user the string with placeholders for actual char

                }

                private void ReadyForNextRound();
                {

                }

                private void CharGuess();
                {

                }

                private void AnswerGuess();
                {

                }
            }
        }
    }

}



//**Ask user what difficulty/Category
//**best of three, five
//Then console write line ready(a bool and yes = true) if true, start game
//call on repo method(field with list) to randomly select string and display # of chars and spaces in string
//user 1 char input
//return char to a foreach loop, and run each char in string, return blanks of valid chars in string, if null then -1 life of user that entered char
//if user1 and 2 lives <1, c.w "A draw, no win add, back to 2
//if user inputs invalid char, then c.w(I'm sorry, please enter a valid letter)
//if successful char is detected, then ask user if they would like to solve.
//      if yes, ask user for input
//         if guess is correct, c.w. Congratulations! You have won this round
//if no, prompt other user to enter a valid char
//going to need _repoList of lives during game, then another list? tallying best of three (if wins <=2, continue next game.)
//if wins = 2 c.w. to that user Congrats! You are the winner
//c.w. to other user You lost.
//press any key to continue(console readline);
//Would you like to play again?(yes = true) if true, go back to 1 command (start game)
//if false, exit
//c.w. "Thanks for playing. See you soon!


//in player class
//what is a player?
//player name, win count, life count.