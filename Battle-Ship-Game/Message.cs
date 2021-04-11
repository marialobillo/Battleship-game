using System;


namespace Battle_Ship_Game
{
    public class Message
    {
        

        public void PrintWelcomeMessage()
        {
            Console.Clear();
            Console.WriteLine(" ** BattleShip Game ** ");
            Console.WriteLine("=======================");

        }

        public void PrintShotResult(bool isMissShot)
        {
            Console.WriteLine("\n");
            if(isMissShot)
            {
                Console.WriteLine("\t** You MISSED the shot. Try again!! **");
            } 
            else
            {
                Console.WriteLine("\t** You hit the BattleShit!! Well done!! **");
            }
            Console.WriteLine("*************************************************");
            
        }
        
        public void PrintGameOver()
        {
            ChangeConsoleColor(ConsoleColor.Red, ConsoleColor.White);
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("----------- GAME OVER --------------------");
            Console.WriteLine("------------------------------------------");
            Console.ResetColor();
        }

        public void PrintGameWon()
        {
            ChangeConsoleColor(ConsoleColor.Green, ConsoleColor.White);
            Console.WriteLine("******************************************");
            Console.WriteLine("***********  YOU WIN!!! ******************");
            Console.WriteLine("******************************************");
            Console.ResetColor();
        }

        public void ChangeConsoleColor(ConsoleColor backgroundColor, ConsoleColor foregroundColor)
        {
            Console.BackgroundColor = backgroundColor;
            Console.ForegroundColor = foregroundColor;
        }
    }
}