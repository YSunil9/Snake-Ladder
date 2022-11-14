using System;

namespace SnakeAndLadder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int playerpos = 0;
            int winPos = 100;
            int diceVal = 0;
            int startPos = 0;
            int currPos1 = 0,currPos2 =0,selectPlayer=1;
            int count1 = 0,count2=0;
           
            while ( currPos2<100 && currPos1<100 )
            {
                Random randomNum = new Random();
                int option = randomNum.Next(3);
                if (selectPlayer == 1)
                {


                    Random random = new Random();
                    int dice = random.Next(1, 7);
                    if (currPos1<100 && currPos1 >=0)
                    {
                        Console.WriteLine("Player 1 Dice Num : " + dice);
                        switch (option)
                        {

                            case 1:
                                currPos1 += dice;
                                Console.WriteLine("Ladder");
                                Console.WriteLine("CurrPos" + currPos1);
                                selectPlayer = 1;
                                if (currPos1 > 100)
                                {
                                    currPos1 -= dice;
                                }

                                break;

                            case 2:
                                currPos1 -= dice;
                                Console.WriteLine("Snake");
                                Console.WriteLine("CurrPos" + currPos1);
                                selectPlayer = 2;
                                if (currPos1 < 0)
                                {
                                    currPos1 = 0;
                                }
                                break;
                            default:
                                Console.WriteLine("No Play");
                                Console.WriteLine("CurrPos" + currPos1);
                                break;
                        }
                        if (currPos1 < 0)
                        {
                            currPos1 = 0;
                        }
                    }
                    count1++;
                }
               else
                {
                    Random random = new Random();
                    int dice = random.Next(1, 7);
                    if (currPos2 < 100 && currPos2 >= 0)
                    {
                        Console.WriteLine("Player 2 Dice Num : " + dice);
                        switch (option)
                        {

                            case 1:
                                currPos2 += dice;
                                Console.WriteLine("Ladder");
                                Console.WriteLine("CurrPos" + currPos2);
                                selectPlayer = 2;
                                if (currPos2 > 100)
                                {
                                    currPos2 -= dice;
                                }

                                break;

                            case 2:
                                currPos2 -= dice;
                                Console.WriteLine("Snake");
                                Console.WriteLine("CurrPos" + currPos2);
                                selectPlayer = 1;
                                if (currPos2 < 0)
                                {
                                    currPos2 = 0;
                                }
                                break;
                            default:
                                Console.WriteLine("No Play");
                                Console.WriteLine("CurrPos" + currPos2);
                                break;
                        }
                        if (currPos2 < 0)
                        {
                            currPos2 = 0;
                        }
                    }
                    count2++;
                }   
            }
            Console.WriteLine();
            Console.WriteLine("Number of Dice count of player 1 " + count1);
            Console.WriteLine("Number of Dice count of player 2 " + count2);
            Console.WriteLine("Total Number of Dice Count " + (count1+count2));
            if (currPos1 == 100)
            {
                Console.WriteLine("player 1 wins");
             
            }
            else
            {
                Console.WriteLine("Player 2 wins");
            }

       
        }

    }
}
