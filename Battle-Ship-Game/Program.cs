using System;

namespace Battle_Ship_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        private static void PrintTutorial() {

            string[,] board = new string[10, 10];

            Console.WriteLine("**************************************");
            Console.WriteLine("Battleship is a strategy guessing game.");
            Console.WriteLine("You will prompted to select a point on a 10x10 grid.");
            Console.WriteLine("The point is made up of an x-value and y-value one square of the grid.");
            Console.WriteLine("You can see here an example of the grid.");

            for (int i = 10; i > 0 ; i-- ) {

                for (int j = 0; j < 10; j++) { 
                     
                }
               
            }

            Console.WriteLine("**************************************");
        }
