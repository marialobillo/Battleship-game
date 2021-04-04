using System;

namespace Battle_Ship_Game
{
    public class Player
    {
        public Shot playerShot = new Shot();


        public Shot AskPlayerForShot()
        {
            Console.WriteLine("Make a valid shot. Numbers from 1 to 10 only.");

            Console.WriteLine("X axis: ");
            string inputX = Console.ReadLine();
            int SpotX;
            if(Int32.TryParse(inputX, out SpotX)){
                playerShot.SpotX = SpotX - 1;
            }
            
            Console.WriteLine("Y axis: ");
            string inputY = Console.ReadLine();
            int SpotY;
            if(Int32.TryParse(inputY, out SpotY)){
                playerShot.SpotY = SpotY - 1;
            }

            return playerShot;
        }

        public bool ValidateShot(Shot shotToValidate)
        {
            bool isValidShot = true;
            if( (shotToValidate.SpotX > 9 || shotToValidate.SpotX < 0) ||
                (shotToValidate.SpotY > 9 || shotToValidate.SpotY < 0) )
            {
                isValidShot = false;
            }
            
            return isValidShot;
        }


    }
}