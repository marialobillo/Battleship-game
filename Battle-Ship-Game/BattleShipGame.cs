using System;
using System.Collections.Generic;


namespace Battle_Ship_Game
{
    public class BattleShipGame
    {
        
        public int[,] gameBoard = new int[10, 10]; 
        Player player = new Player();

        public void InitializeGame(){

            // List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            
            // Set the board, place the ship
            initBoardGame();
            printBoardGame();
            // placeBattleShip();

            // Print the board game


        }


        public static void placeBattleShip()
        {
            // Place randomly a 5 length battleship
            Random random = new Random();
            int direction = 0;
            // int dimension = 10;

            if( (random.Next(0,2) % 2) == 0 )
            {
                // Horizontilly
                direction = 0;
                Console.Write("Horizontally {0}", direction);

            } else            
            {
                // Vertically
                direction = 1;
                Console.Write("Vertically {0}", direction);

            }


        }

        public void initBoardGame()
        {
            Console.WriteLine("El tablero está aqui!!");
            Console.WriteLine("========================");

            foreach (var CoordX in numbers)
            {
                foreach (var CoordY in numbers)
                {
                    gameBoard[CoordX, CoordY] = SpotStatus.Empty;
                }
            }
        }


        public void printBoardGame()
        {
            foreach (var CoordX in numbers)
            {
                foreach (var CoordY in numbers)
                {
                   // Print the emptyness
                   boardGame
                }
            }
        }

        // private static void AddPointToGameBoard(int CoordX, int CoordY)
        // {
        //     BoardGame point = new BoardGame
        //     {
        //         SpotX = CoordX;
        //         SpotY = CoordY;
        //         Status = SpotStatus.Empty;
        //     }

        //     boardGame.Add(point);
        // }
    }
}