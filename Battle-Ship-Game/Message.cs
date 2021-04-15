using System;


namespace Battle_Ship_Game
{
    public class Message
    {
        

        public void PrintWelcomeMessage()
        {
            Console.Clear();
            Console.WriteLine("\n ** BattleShip Game ** ");
            Console.WriteLine("=======================");

        }

        public void PrintShotResult(bool isMissShot)
        {
            Console.WriteLine("\n");
            if(isMissShot)
            {
                ChangeConsoleColor(ConsoleColor.Red, ConsoleColor.White);
                Console.WriteLine("\t*** You MISS. Try again!! ***");
            } 
            else
            {
                ChangeConsoleColor(ConsoleColor.Green, ConsoleColor.Black);
                Console.WriteLine("\t*** You HIT. Well done!! ***");
            }
            Console.WriteLine("-----------------------------------------------");
            Console.ResetColor();
        }

        

        public void PrintGameOver()
        {
            ChangeConsoleColor(ConsoleColor.Red, ConsoleColor.White);
            Console.WriteLine("//////////////////////////////////////////////////");
            Console.WriteLine("/////////// Game Over ////////////////////////////");
            Console.WriteLine("//////////////////////////////////////////////////");
            Console.ResetColor();
        }

        public void PrintGameWon()
        {
            ChangeConsoleColor(ConsoleColor.Green, ConsoleColor.White);
            Console.WriteLine("//////////////////////////////////////////////////");
            Console.WriteLine("/////////// You Won!! ////////////////////////////");
            Console.WriteLine("//////////////////////////////////////////////////");
            Console.ResetColor();
        }
        

        public void ChangeConsoleColor(ConsoleColor backgroundColor, ConsoleColor foregroundColor)
        {
            Console.BackgroundColor = backgroundColor;
            Console.ForegroundColor = foregroundColor;
        }
    }
}