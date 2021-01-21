using System;

namespace Task09
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is a simple *Rock, Paper or Scissor-Game* against the computer. First to 3 wins!\n\n");
            ScoreBoard scoreboard01 = new ScoreBoard();
            Human player01 = new Human();
            Computer computer01 = new Computer();
            while (scoreboard01.score[0] < 3 && scoreboard01.score[1] < 3)
            {
                player01.move = player01.Move();
                computer01.move = computer01.Move();
                Console.WriteLine("\n" + player01.name + ": " + player01.move + "\n" + computer01.name + ": " + computer01.move);
                scoreboard01.score = scoreboard01.GetScore(scoreboard01, player01, computer01);
                scoreboard01.DisplayScore(scoreboard01, player01, computer01);
            }
            if (scoreboard01.score[0] > scoreboard01.score[1]) { Console.WriteLine(player01.name + " WIN!"); }
            else { Console.WriteLine(computer01.name + " WIN!"); }
            Console.ReadKey(); 
        }
    }
}