using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snakeandladdergame
{
     class snakeladder
    {
        public void Startgame()
        {
            int[] snake = { 16, 47, 49, 56, 62, 64, 87, 93, 95, 98 };
            int[] ladder = { 1, 4, 9, 21, 28, 36, 51, 71, 80 };
            Console.WriteLine("Start the snake and ladder game");
            int user1dicevalue = 0; // user1 position 

            int Rolldice()
            {
                Random random = new Random();
                int rolledvalues = random.Next(1, 7);
                return rolledvalues;
            }
        }
        static void Main(string[] args)
        {
            snakeladder game=new snakeladder();
            game.Startgame();
        }
    }
}
