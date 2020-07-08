using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pair_Programming_Console_Game
{
    class Program
    {
        static void Main(string[] args)
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
                    "Select Number of Players \n" +
                    "1 Player \n" +
                    "2 Players \n" +
                    "Exit");
                string userInput = Console.ReadLine();
            }
        }

        private void EasyWordList()
        {
            //COPIED FROM STREAMNING CONTENT EXAMPLE TO CREATE WORDS?????
            StreamingContent wordOne = new StreamingContent(“cat”);
            StreamingContent wordTwo = new StreamingContent(“dog”);
            StreamingContent wordThree = new StreamingContent(“bird”);
            _streamingRepo.AddContentToDirectory(wordOne);
            _streamingRepo.AddContentToDirectory(wordTwo);
            _streamingRepo.AddContentToDirectory(wordThree);

            //CREATING AN ARRAY OF STRINGS - THIS MIGHT BE THE WAY TO GO??
            string[] words = new string[3];
            words[0]= "cat";
            words[1]= "dog";
            words[2] = "bird";

            //LOGIC TO SELECT RANDOM WORD AND TAKE USER INPUT TO CHECK IF LETTER GUESS IS IN THE WORD
            //Random wordToGuess = new Random();
            //var word = wordToGuess.Next(0, 2);

            //FOR LOOP TO CHECK USER GUESS AGAINST RANDOM WORD
            for (char i = 0; i < words.Length; i++) ;



        }

    }
}





//Pair Programming Notes
//Program UI
     //Run Console
     //Display Options to user
        //Difficulty Input, Best Of Input
//Class1(Player Class)
    //User1
      //Wins
        //# of wrong moves
    //User 2 wins

//TestClass





//Additional Notes
    //.Next used to randomly generate a word or phrase(for strings)