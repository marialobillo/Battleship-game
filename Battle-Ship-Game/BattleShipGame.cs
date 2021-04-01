using System;
using System.Collections.Generic;


namespace Battle_Ship_Game
{
    public class BattleShipGame
    {
        
        public SpotStatus[,] gameBoard = new SpotStatus[10, 10]; 
        Player player = new Player();

        List<int> numbers = new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

        public void InitializeGame(){

            
            
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
            string gridLine = "";
            string secondLine = "===";
            // Print 1-10 for columns
            foreach (var CoordY in numbers){
                gridLine = gridLine + "    " + (CoordY + 1);
                secondLine = secondLine + "=====";
            }
            Console.WriteLine(gridLine);
            Console.WriteLine(secondLine);
            // Print the board
            gridLine = "";
            foreach (var CoordX in numbers)
            {
                gridLine = (CoordX + 1) + ") ";
                foreach (var CoordY in numbers)
                {
                   // Print the board
                   if(gameBoard[CoordX, CoordY] == SpotStatus.Empty){
                       gridLine = gridLine + "  ~  ";
                   }
                   if(gameBoard[CoordX, CoordY] == SpotStatus.Ship){
                       gridLine = gridLine + " WPW ";
                   }
                   if(gameBoard[CoordX, CoordY] == SpotStatus.Miss){
                       gridLine = gridLine + "  O  ";
                   }
                   if(gameBoard[CoordX, CoordY] == SpotStatus.Hit){
                       gridLine = gridLine + "  X  ";
                   }
                   if(gameBoard[CoordX, CoordY] == SpotStatus.Sunk){
                       gridLine = gridLine + "  [X]  ";
                   }
                   if(CoordY == 9)
                   {
                       Console.Write('\n');
                   }
                   
                }
                Console.WriteLine(gridLine);
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