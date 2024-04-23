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

            int user2dicevalue = 0;
            while (true)
            {
                //Console.WriteLine("who is playing press 1 for user1 and 2 user2");
                int user = 0;
                // int user=Convert.ToInt32(Console.ReadLine());
                if (user == 0)
                {
                    Console.WriteLine("press any key to roll the dice ");
                    user1dicevalue = Rolldice();
                    for (int i = 0; i <= snake.Length - 1; i++)
                    {
                        if (user1dicevalue == snake[i])
                        {
                            user1dicevalue -= 10;
                        }
                    }

                    for (int j = 0; j <= ladder.Length - 1; j++)
                    {
                        if (user1dicevalue == ladder[j])
                        {
                            user1dicevalue += 10;
                        }
                    }
                    user++;
                }
                else
                {
                    Console.WriteLine("press any key to roll the dice ");
                    user2dicevalue = Rolldice();
                    for (int i = 0; i <= snake.Length - 1; i++)
                    {
                        if (user2dicevalue == snake[i])
                        {
                            user1dicevalue -= 10;
                        }
                    }

                    for (int j = 0; j <= ladder.Length - 1; j++)
                    {
                        if (user2dicevalue == ladder[j])
                        {
                            user2dicevalue += 10;
                        }
                    }
                    user--;
                }
            }
            static void Main(string[] args)
            {
                snakeladder game = new snakeladder();
                game.Startgame();
            }
        }
    }
}
