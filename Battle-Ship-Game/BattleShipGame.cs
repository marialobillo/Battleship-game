using System;
using System.Collections.Generic;


namespace Battle_Ship_Game
{
    public class BattleShipGame
    {
        
        public SpotStatus[,] gameBoard = new SpotStatus[10, 10]; 
        Player player = new Player();
        Message message = new Message();

        List<int> numbers = new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

        int Attemps = 10;
        int ShipHits = 5;

        bool isMissShot = true;
        // ShotStatus isCheckedShot = ShotStatus.NoValidated;
        bool isCheckedShot = false;

        public bool InitializeGame(){

            // Set the board, place the ship
            InitializeBoardGame();
            placeBattleShip();

            // Print the board game
            printBoardGame();
            
            return true;
        }

        public void GameLoop(bool isGameActive)
        {

             while(isGameActive)
            {
                // Ask Player for a Shot
                
               
                bool isValidUniqueShot = AskForValidUniqueShot();
               
                // Check the Shot...hit, miss, 
                // Update the board
                // Notice the shot to the Player
                if(isValidUniqueShot)
                {
                    isCheckedShot = CheckShotOnBoard();
                } 

               

                if(isCheckedShot)
                {
                    printBoardGame();
                    if(Attemps == 0 || ShipHits == 0)
                    {
                        // GameOver or we wont!!
                        isGameActive = false;
                    }
                }
                
                PrintAttempsAndHits();

                // end the game
                // isGameActive = false;
            }
        }

        public void PrintAttempsAndHits()
        {
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("|    Remaining attemps: {0}     |    Hits: {1}    |", Attemps, ShipHits);
            Console.WriteLine("----------------------------------------------");
        }

        public bool AskForValidUniqueShot()
        {
            bool isValidShot = false;
            bool isUniqueShot = false;

            do 
            {
                player.playerShot = player.AskPlayerForShot();
                isValidShot = player.ValidateShot(player.playerShot);
                if(isValidShot){
                    isUniqueShot = CheckUniqueShot(player.playerShot);
                } else 
                {
                    Console.WriteLine("IsValidShot is FALSE");
                }
            } while(!isUniqueShot);
            
            return isUniqueShot;
        }

        public bool CheckShotOnBoard()
        {
            int SpotX = player.playerShot.SpotX;
            int SpotY = player.playerShot.SpotY;

            if(gameBoard[SpotX, SpotY] == SpotStatus.Ship)
            {
                // We are shotting on the ship
                // We have to count 5 - 1 = on the ship
                ShipHits = ShipHits - 1;
                // For the attemps 10 - 1
                isMissShot = false;
                Attemps = Attemps - 1;
                gameBoard[SpotX, SpotY] = SpotStatus.Hit;
            } else if (gameBoard[SpotX, SpotY] == SpotStatus.Empty)
            {
                // For the attemps 10 - 1 = water
                Attemps = Attemps - 1;
                gameBoard[SpotX, SpotY] = SpotStatus.Miss;
                isMissShot = true;
            }
            return true;
        }

        public void InitializeBoardGame()
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

                // For Coord_X we got from 0 - to (10-5) = 5
                int CoordX = random.Next(0, 5);  // left side of the ship + 5 spots
                // For Coord_Y we got the full range, and a constant for the ship
                int CoordY = random.Next(0, 10);

                for (var i = CoordX; i <= CoordX + 4; i++)
                {
                    for(var j = CoordY; j <= CoordY; j ++)
                    {
                        gameBoard[i, j] = SpotStatus.Ship;

                    }
                }

            } else            
            {
                // Vertically
                direction = 1;

                // For Coord_X we got the full range, and a constant for the ship
                int CoordX = random.Next(0, 10);
                // For Coord_Y we got from 0 - to (10-5) = 5
                int CoordY = random.Next(0, 5);  // left side of the ship + 5 spots               

                for (var i = CoordX; i <= CoordX; i++)
                {
                    for(var j = CoordY; j <= CoordY + 4; j ++)
                    {
                        gameBoard[i, j] = SpotStatus.Ship;
                    }
                }

            }


        }

       


        public void printBoardGame()
        {
            message.PrintWelcomeMessage();
           

            string gridLine = "";
            string secondLine = "---";
            // Print 1-10 for columns
            foreach (var CoordY in numbers){
                gridLine = gridLine + "    " + (CoordY + 1);
                secondLine = secondLine + "-----";
            }
            Console.WriteLine(gridLine);
            Console.WriteLine(secondLine);
            // Print the board
            gridLine = "";
            foreach (var CoordY in numbers)
            {
                gridLine = (CoordY + 1) + ") ";
                foreach (var CoordX in numbers)
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
                       gridLine = gridLine + " !!X!! ";
                   }
                   if(CoordX == 9)
                   {
                       Console.Write('\n');
                   }
                   
                }
                Console.WriteLine(gridLine);
            }   

            if(isCheckedShot)
            {
                message.PrintShotResult(isMissShot);

            }         
        }

        public bool CheckUniqueShot(Shot shotToValidate)
        {
            bool isUniqueShot = true;

            foreach (var CoordX in numbers)
            {
                foreach (var CoordY in numbers)
                {
                    if(gameBoard[shotToValidate.SpotX,shotToValidate.SpotY] == SpotStatus.Hit ||
                    gameBoard[shotToValidate.SpotX,shotToValidate.SpotY] == SpotStatus.Miss)
                    {
                        isUniqueShot = false;
                    }
                }
            }

            return isUniqueShot;
        }

    }
}