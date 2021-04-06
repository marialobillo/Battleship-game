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
                isGameActive = game.InitializeGame();
            }

            

           game.GameLoop(isGameActive);

            
        }

        public static bool AskForNewGame()
        {
            Message message = new Message();
            bool isPlayerReady = false;
            
          
            message.PrintWelcomeMessage();

            Console.WriteLine("Do you want to play BattleShip Game?");
            Console.WriteLine("Please type 'yes' or something else to quit:");
            Console.Write("> ");
            string input = Console.ReadLine();
            if(input == "yes"){
                isPlayerReady = true;
            }
            
            return isPlayerReady;
        }

        public static void AskUserForShot()
        {

        }

       

       
        



    }    

} 
