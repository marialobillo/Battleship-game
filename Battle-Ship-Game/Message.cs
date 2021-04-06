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
                Console.WriteLine("\t** You missed the shot. Try again!! **");
            } 
            else
            {
                Console.WriteLine("\t** You hit the BattleShit!! Well done!! **");
            }
            Console.WriteLine("*************************************************");
            
        }
    }
}