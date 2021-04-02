using System;

namespace Battle_Ship_Game
{
    class Program
    {
        public static bool isGameActive = false;
        
        static void Main(string[] args)
        {
            // bool isGameActive = false;
            BattleShipGame game = new BattleShipGame();
            

            //PrintWelcomeMessage();
            if(AskForNewGame()){
                Console.WriteLine("We are gonna play!!");
                isGameActive = game.InitializeGame();
            }

            

           game.GameLoop(isGameActive);

            
        }

        public static bool AskForNewGame()
        {
            
            bool isPlayerReady = false;
            
          
            PrintWelcomeMessage();

            Console.WriteLine("Do you want to play BattleShip Game?");
            Console.WriteLine("Please type 'yes' or 'no':");
            Console.Write("> ");
            string input = Console.ReadLine();
            if(input == "no")
            {
                isPlayerReady = false;
            } else if(input == "yes"){
                isPlayerReady = true;
            }
            
            return isPlayerReady;
        }

        public static void AskUserForShot()
        {

        }

        public static void PrintWelcomeMessage()
        {
            Console.Clear();
            Console.WriteLine(" ** BattleShip Game ** ");
            Console.WriteLine("=======================");

        }

       
        



    }    

} 
