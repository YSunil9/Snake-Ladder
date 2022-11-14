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
            int currPos = 0;
           
          
            

            while (  currPos<100 )
            {
                Random randomNum = new Random();
                int option = randomNum.Next(3);
                Random random = new Random();
                int dice = random.Next(1, 7);
                Console.WriteLine("Dice Num : " + dice);

                switch (option)
                {

                    case 1:
                        currPos += dice;
                        Console.WriteLine("Ladder");
                        Console.WriteLine("CurrPos" + currPos);
                        if(currPos > 100)
                        {
                            currPos -=dice;
                        }

                        break;

                    case 2:
                        currPos -= dice;
                        Console.WriteLine("Snake");
                        Console.WriteLine("CurrPos" + currPos);
                        if (currPos < 0)
                        {
                            currPos=0;
                        }
                        
                        break;
                    default:
                        Console.WriteLine("No Play");
                        Console.WriteLine("CurrPos" + currPos);
                        break;
                }
               

            }
            Console.WriteLine("CurrPos" + currPos);
        }

    }
}
