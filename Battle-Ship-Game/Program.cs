using System;

namespace Battle_Ship_Game
{
    class Program
    {
        
        static void Main(string[] args)
        {
            BattleShipGame game = new BattleShipGame();
            Player player = new Player();

            //PrintWelcomeMessage();

            if(AskForNewGame()){
                Console.WriteLine("We are gonna play!!");
                game.InitializeGame();
            }

            
        }

        public static bool AskForNewGame()
        {
            

            bool isGameActive = false;
          
            PrintWelcomeMessage();

            Console.WriteLine("Do you want to play BattleShip Game?");
            Console.WriteLine("Please type 'yes' or 'no':");
            Console.Write("> ");
            string input = Console.ReadLine();
            if(input == "no")
            {
                isGameActive = false;
            } else if(input == "yes"){
                isGameActive = true;
            }
            
            return isGameActive;
        }

        public static void PrintWelcomeMessage()
        {
            Console.Clear();
            Console.WriteLine(" ** BattleShip Game ** ");
            Console.WriteLine("=======================");

        }

       
        



    }    

} 
