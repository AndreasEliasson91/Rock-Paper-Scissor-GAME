using System;

namespace Task09
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] score = new int[2] {0,0};
            string playerMove, computerMove;
            do
            {
                playerMove = PlayerMove();
                computerMove = ComputerMove();
                score = GetPoint(score, playerMove, computerMove);
                Console.WriteLine(score[0] + " - " + score[1] + "\n");
            } while (score[0] <= 5 || score[1] <= 5);
        }
        static string PlayerMove()
        {
            Console.WriteLine("Rock, Paper or Scissor?");
            string move = Console.ReadLine();
            move = move.ToUpper();
            Console.WriteLine("PLAYER: " + move);
            return move;
        }
        static string ComputerMove()
        {
            Random randNum = new Random();
            int num = randNum.Next(3);
            string move = "";
            if (num == 0) { move = "ROCK"; }
            else if (num == 1) { move = "PAPER"; }
            else { move = "SCISSOR"; }
            Console.WriteLine("COMPUTER: " + move);
            return move;
        }
        static int[] GetPoint(int[] currentScore, string player, string computer)
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
