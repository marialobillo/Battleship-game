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
                playerShot.SpotX = SpotX;
            }
            
            Console.WriteLine("Y axis: ");
            string inputY = Console.ReadLine();
            int SpotY;
            if(Int32.TryParse(inputY, out SpotY)){
                playerShot.SpotY = SpotY;
            }

            return playerShot;
        }

        public bool ValidateShot(Shot shotToValidate)
        {
            bool isValidShot = true;
            if( (shotToValidate.SpotX > 10 || shotToValidate.SpotX < 1) ||
                (shotToValidate.SpotY > 10 || shotToValidate.SpotY < 1) )
            {
                isValidShot = false;
            }
            
            return isValidShot;
        }


        public bool ValidateShot(int Spot){
            if(Spot < 1 || Spot > 10)
            {
                return false;
            }
            return true;
        }
    }
}