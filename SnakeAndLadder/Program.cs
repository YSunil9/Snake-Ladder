namespace SnakeAndLadder
{
    internal class Program
    {
        static void Main(string[] args)
        {
        
            int winPos   = 100;
            int diceVal  = 0;
            int startPos = 0;
            int currPos  = 0;   
            Random random = new Random();
            int dice = random.Next(1,7);
            Console.WriteLine("Dice Num : " + dice);
            Random randomNum = new Random();
            int option=randomNum.Next(3);   
            switch(option)
            {
                case 1: 
              currPos += dice;
                    Console.WriteLine("Ladder");
                    break;

                case 2:
                    currPos -= dice;
                    Console.WriteLine("Snake");
                    break;
                default:
                    Console.WriteLine("No Play");
                    break;
            }
        }
               
    }
}
 