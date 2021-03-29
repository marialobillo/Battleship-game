using System;

namespace Battle_Ship_Game
{
    class Program
    {
        

        static void Main(string[] args)
        {
            PrintHelloMessage();
            bool isGamePlaying = AskStartGame();

            do{
                
            }while(isGamePlaying == true);
        }

       
        public static void PrintHelloMessage(){
            Console.WriteLine("** Welcome to The BattleShip Game! **");
        }

        public static bool AskStartGame(){
            Console.WriteLine("Do you want to start playing? (Answer: 'yes' or 'no' )");
            bool isValidAnswer = false;
            do{

                string input = Console.ReadLine();
                if(input == "yes")
                {   
                    isValidAnswer = true;
                    return true;
                }else if(input == "no")
                {
                    isValidAnswer = true;
                    return false;
                } else {
                    Console.WriteLine("Please write a valid answer: 'yes' or 'no'.");
                    isValidAnswer = false;
                }
            } while(isValidAnswer == false); 
            return false;
        }



    }    

} 
