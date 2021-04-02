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
            placeBattleShip();

            // Print the board game
            printBoardGame();
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


        public void placeBattleShip()
        {
            // Place randomly a 5 length battleship
            Random random = new Random();
            int direction = 0;
            // int dimension = 10;

            if( (random.Next(0,2) % 2) == 0 )
            {
                // Horizontilly
                direction = 0;
                Console.WriteLine("Horizontally {0}", direction);

                
                // For Coord_X we got from 0 - to (10-5) = 5
                int CoordX = random.Next(0, 5);  // left side of the ship + 5 spots
                // For Coord_Y we got the full range, and a constant for the ship
                int CoordY = random.Next(0, 10);

                Console.WriteLine("The X: {0}", CoordX);
                Console.WriteLine("The Y: {0}", CoordY);

                for (var i = CoordX; i <= CoordX + 4; i++)
                {
                    for(var j = CoordY; j <= CoordY; j ++)
                    {
                        //gameBoard[i, j] = SpotStatus.Ship;
                        Console.WriteLine("i => " + i);
                        Console.WriteLine("j => " + j);
                        gameBoard[i, j] = SpotStatus.Ship;

                    }
                }



            } else            
            {
                // Vertically
                direction = 1;
                Console.WriteLine("Vertically {0}", direction);


                // For Coord_X we got the full range, and a constant for the ship
                int CoordX = random.Next(0, 10);
                // For Coord_Y we got from 0 - to (10-5) = 5
                int CoordY = random.Next(0, 5);  // left side of the ship + 5 spots               

                Console.WriteLine("The X: {0}", CoordX);
                Console.WriteLine("The Y: {0}", CoordY);

                for (var i = CoordX; i <= CoordX; i++)
                {
                    for(var j = CoordY; j <= CoordY + 4; j ++)
                    {
                        //gameBoard[i, j] = SpotStatus.Ship;
                        Console.WriteLine("i => " + i);
                        Console.WriteLine("j => " + j);
                        gameBoard[i, j] = SpotStatus.Ship;
                    }
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

    }
}