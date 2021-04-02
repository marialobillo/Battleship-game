using System;

namespace Battle_Ship_Game
{
    public class Player
    {
        public Shot playerShot = new Shot();


        public Shot AskPlayerForShot()
        {
            Console.WriteLine("It's your turn. Make a valid shot. Numbers from 1 to 10 only.");

            Console.WriteLine("X axis: ");
            playerShot.SpotX = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Y axis: ");
            playerShot.SpotY = Convert.ToInt32(Console.ReadLine());

            return playerShot;
        }


        public bool ValidateShot(int Spot){
            if(Spot > 10 || Spot < 1)
            {
                return false;
            }
            return true;
        }
    }
}