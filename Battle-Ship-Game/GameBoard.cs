using System;

namespace Battle_Ship_Game
{
    public class GameBoard
    {
        public GridPointStatus [,] GridBoard = new GridPointStatus[10, 10]; 

       
        public void initializeBoard()
        {
           for(int i = 0; i < 10; i++)
           {
               for(int j = 0; j < 10; j++)
               {
                   GridBoard[i,j] = GridPointStatus.Empty;
               }
           }
        }

        public static void printBoard()
        {
            
        }

        public static void updateBoard()
        {

        }
        public static void cleanBoard()
        {

        }

        
    }
}