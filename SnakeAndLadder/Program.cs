﻿namespace SnakeAndLadder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int pos = 0;
            Console.WriteLine("single player at start position", +pos);
            RollDice();
        }
         public static void  RollDice()
        {
            Random random = new Random();
            int dice = random.Next(6);
            dice = dice + 1;
            Console.WriteLine("Dice Num : " + dice);
        }
    }
}