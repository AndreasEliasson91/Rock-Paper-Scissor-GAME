using System;

namespace Task09
{
    class Game
    {
        public string[] selections = new string[3] { "ROCK", "PAPER", "SCISSOR"};
        public string move;
        public int num;
    }
    class Player : Game
    {
        Player()
        {
            move = Move();
        }
        public string Move()
        {
            Console.WriteLine("Type 1 for ROCK, 2 for PAPER or 3 for SCISSOR: ");
            num = Convert.ToInt32(Console.ReadLine());
            return selections[num];
        }
    }
    class Computer : Game
    {
        Computer()
        {
            move = Move();
        }
        public string Move()
        {
            Random randNum = new Random();
            num = randNum.Next(3);
            return selections[num];
        }
    }
}