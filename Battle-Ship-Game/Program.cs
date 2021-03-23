using System;

namespace Battle_Ship_Game
{
    class Program
    {

        public struct Coords
        {
            public Coords(double x, double y)
            {
                X = x;
                Y = y;
            }

            public double X { get; }
            public double Y { get; }

            public override string ToString() => $"({X}, {Y})";
        }


        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

    }    

} 
