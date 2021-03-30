using System;

namespace Battle_Ship_Game
{
    public class BattleShipGame
    {
        
        BoardGame boardGame = new BoardGame();
        Player player = new Player();

        public static void InitializeGame(){
            // Set the board, place the ship

            // Print the board game


        }

        public static void placeBattleShip()
        {
            // Place randomly a 5 length battleship
            Random random = new Random();
            int direction = random.Next(0, 2);
            int dimension = 10;

            if(direction == 0)
            {
                // Horizontilly


            } else if (direction == 1)
            {
                // Vertically
            }


        }
    }
}