using System;

namespace Task09
{
    class Players
    {
        public string[] selections = new string[3] { "ROCK", "PAPER", "SCISSOR"};
        public string move, name;
        public int num;
        public Random randNum = new Random();
    }
    class Human : Players
    {
        public Human()
        {
            name = SetName();
            Console.WriteLine("PLAYER NAME: " + name);
        }
        public string SetName()
        {
            Console.WriteLine("Please enter your name: ");
            name = Console.ReadLine();
            name = name.ToUpper();
            return name;
        }
        public string Move()
        {
            bool loop;
            do
            {
                loop = false;
                Console.WriteLine("Type 0 for ROCK, 1 for PAPER or 2 for SCISSOR: ");
                num = Convert.ToInt32(Console.ReadLine());
                if (num > 3) 
                {
                    Console.WriteLine("Invalid entry, try again!");
                    loop = true;
                }
            } while (loop == true);
            return selections[num];
        }
    }
    class Computer : Players
    {
        public Computer()
        {
            name = SetName();
            Console.WriteLine("COMPUTER NAME: " + name);
        }
        public string SetName()
        {
            num = randNum.Next(3);
            if (num == 0)   { name = "DONALD"; }
            else if (num == 1)  { name = "RICHARD"; }
            else    { name = "JOHN"; }
            return name;
        }
        public string Move()
        {
            num = randNum.Next(3);
            return selections[num];
        }
    }
    class ScoreBoard
    {
        public int[] score;

        public ScoreBoard()
        {
            score = new int[2] { 0, 0 };
        }
        public void DisplayScore(ScoreBoard scoreboard, Human player, Computer comp) { Console.WriteLine(player.name + ": " + scoreboard.score[0] + "\n" + comp.name + ": " + scoreboard.score[1] + "\n"); }
        public int[] GetScore(ScoreBoard scoreboard, Human player, Computer comp)
        {  
            if (player.move == comp.move) { Console.WriteLine("\nIt's a TIE, no points!\n"); }
            else if (player.move == "ROCK" && comp.move == "PAPER")
            {
                Console.WriteLine("\nPoint to " + comp.name + "!\n");
                scoreboard.score[1]++;
            }
            else if (player.move == "ROCK" && comp.move == "SCISSOR")
            {
                Console.WriteLine("\nPoint to " + player.name + "!\n");
                scoreboard.score[0]++;
            }
            else if (player.move == "SCISSOR" && comp.move == "PAPER")
            {
                Console.WriteLine("\nPoint to " + player.name + "!\n");
                scoreboard.score[0]++;
            }
            else if (player.move == "SCISSOR" && comp.move == "ROCK")
            {
                Console.WriteLine("\nPoint to " + comp.name + "!\n");
                scoreboard.score[1]++;
            }
            else if (player.move == "PAPER" && comp.move == "ROCK")
            {
                Console.WriteLine("\nPoint to " + player.name + "!\n");
                scoreboard.score[0]++;
            }
            else if (player.move == "PAPER" && comp.move == "SCISSOR")
            {
                Console.WriteLine("\nPoint to " + comp.name + "!\n");
                scoreboard.score[1]++;
            }
            return scoreboard.score;
        }
    }
}