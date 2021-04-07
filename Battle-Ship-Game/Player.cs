using System;

namespace Battle_Ship_Game
{
    public class Player
    {
        public Shot playerShot = new Shot();


        public Shot AskPlayerForShot()
        {
            Console.WriteLine("Make a valid shot. Numbers from 1 to 10 only. \n");
            // Asking X axis coordinate
            Console.WriteLine("X axis: ");
            Console.Write("> ");
            string inputX = Console.ReadLine();
            int SpotX;
            if(Int32.TryParse(inputX, out SpotX)){
                playerShot.SpotX = SpotX - 1;
            } else {
                playerShot.SpotX = 12;  // Out of grid range
            }
            // Asking Y axis coordinate   
            Console.WriteLine("Y axis: ");
            Console.Write("> ");
            string inputY = Console.ReadLine();
            int SpotY;
            if(Int32.TryParse(inputY, out SpotY)){
                playerShot.SpotY = SpotY - 1;
            } else {
                playerShot.SpotY = 12;
            }
            return playerShot;
        }

        public bool ValidateShot(Shot shotToValidate)
        {
            bool isValidShot = false;
            if( (shotToValidate.SpotX < 10 && shotToValidate.SpotX >= 0) &&
                (shotToValidate.SpotY < 10 && shotToValidate.SpotY >= 0) )
            {
                isValidShot = true;
                Console.WriteLine("X : ", shotToValidate.SpotX);
                Console.WriteLine("Y : ", shotToValidate.SpotY);
            }
            
            return isValidShot;
        }


    }
}