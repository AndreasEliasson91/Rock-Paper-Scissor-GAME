using System;

namespace Task09
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Rock, Paper or Scissor game against the computer. First to 3 wins!\n\n");
            int[] score = new int[2] {0,0};
            string playerMove, computerMove;
            while (score[0] < 3 && score[1] < 3)
            {
                playerMove = PlayerMove();
                computerMove = ComputerMove();
                score = GetScore(score, playerMove, computerMove);
                Console.WriteLine(score[0] + " - " + score[1] + "\n");
            }
            if (score[0] > score[1]) { Console.WriteLine("PLAYER WIN!"); }
            else { Console.WriteLine("COMPUTER WIN!"); }
            Console.ReadKey(); 
        }
        static string PlayerMove()
        {
            bool loop;
            string move;
            do
            {
                loop = false;
                Console.WriteLine("Rock, Paper or Scissor?");
                move = Console.ReadLine();
                move = move.ToUpper();
                if (move == "ROCK" || move == "PAPER" || move == "SCISSOR") { continue; }
                else
                {
                    Console.WriteLine("Invalid entry! Try again.\n");
                    loop = true;
                }
            } while (loop == true);
            Console.WriteLine("PLAYER: " + move);
            return move;
        }
        static string ComputerMove()
        {
            Random randNum = new Random();
            int num = randNum.Next(3);
            string[] move = new string[3] { "ROCK", "PAPER", "SCISSOR" };
            Console.WriteLine("COMPUTER: " + move[num]);
            return move[num];
        }
        static int[] GetScore(int[] currentScore, string player, string computer)
        {  
            if (player == computer) { Console.WriteLine("It's a Tie!"); }
            else if (player == "ROCK" && computer == "PAPER")
            {
                Console.WriteLine("Point to computer!");
                currentScore[1]++;
            }
            else if (player == "ROCK" && computer == "SCISSOR")
            {
                Console.WriteLine("Point to player!");
                currentScore[0]++;
            }
            else if (player == "SCISSOR" && computer == "PAPER")
            {
                Console.WriteLine("Point to player!");
                currentScore[0]++;
            }
            else if (player == "SCISSOR" && computer == "ROCK")
            {
                Console.WriteLine("Point to computer!");
                currentScore[1]++;
            }
            else if (player == "PAPER" && computer == "ROCK")
            {
                Console.WriteLine("Point to player!");
                currentScore[0]++;
            }
            else if (player == "PAPER" && computer == "SCISSOR")
            {
                Console.WriteLine("Point to computer!");
                currentScore[1]++;
            }
            return currentScore;
        }
    
    }
}
