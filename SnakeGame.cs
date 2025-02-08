using System;
using System.Collections.Generic;
using System.Threading;

namespace SnakeGame
{
    class Program
    {
        static void Main()
        {
            Coord gridDimensions = new Coord(50, 20);
            Coord snakePos = new Coord(10, 1);
            Random rand = new Random();
            Coord applePos = new Coord(rand.Next(1, gridDimensions.X - 1), rand.Next(1, gridDimensions.Y - 1));
            int frameDelayMilli = 100;
            Direction movementDirection = Direction.Down;

            List<Coord> snakePosHistory = new List<Coord>();
            int tailLength = 1;
            int score = 0;

            Console.CursorVisible = false;
            Console.Clear();

            void DrawBorders()
            {
                for (int y = 0; y < gridDimensions.Y; y++)
                    for (int x = 0; x < gridDimensions.X; x++)
                    {
                        Console.SetCursorPosition(x, y);
                        Console.Write((x == 0 || y == 0 || x == gridDimensions.X - 1 || y == gridDimensions.Y - 1) ? "#" : " ");
                    }
            }

            DrawBorders();

            while (true)
            {
                Console.SetCursorPosition(0, gridDimensions.Y);
                Console.Write("Score: " + score + " ");

                Console.SetCursorPosition(applePos.X, applePos.Y);
                Console.Write("a");

                snakePos.ApplyMovementDirection(movementDirection);
                Console.SetCursorPosition(snakePos.X, snakePos.Y);
                Console.Write("■");
                
                if (snakePos.Equals(applePos))
                {
                    tailLength++;
                    score++;
                    applePos = new Coord(rand.Next(1, gridDimensions.X - 1), rand.Next(1, gridDimensions.Y - 1));
                }
                else if (snakePos.X == 0 || snakePos.Y == 0 || snakePos.X == gridDimensions.X - 1 || snakePos.Y == gridDimensions.Y - 1 || snakePosHistory.Contains(snakePos))
                {
                    foreach (Coord c in snakePosHistory)
                    {
                        Console.SetCursorPosition(c.X, c.Y);
                        Console.Write(" ");
                    }
                    Console.SetCursorPosition(snakePos.X, snakePos.Y);
                    Console.Write(" ");
                    
                    score = 0;
                    tailLength = 1;
                    snakePos = new Coord(10, 1);
                    snakePosHistory.Clear();
                    movementDirection = Direction.Down;
                    Console.Clear();
                    DrawBorders();
                    continue;
                }

                snakePosHistory.Add(new Coord(snakePos.X, snakePos.Y));
                if (snakePosHistory.Count > tailLength)
                {
                    Coord tail = snakePosHistory[0];
                    Console.SetCursorPosition(tail.X, tail.Y);
                    Console.Write(" ");
                    snakePosHistory.RemoveAt(0);
                }

                DateTime time = DateTime.Now;
                while ((DateTime.Now - time).Milliseconds < frameDelayMilli)
                {
                    if (Console.KeyAvailable)
                    {
                        ConsoleKey key = Console.ReadKey(true).Key;
                        if (key == ConsoleKey.W) movementDirection = Direction.Up;
                        else if (key == ConsoleKey.S) movementDirection = Direction.Down;
                        else if (key == ConsoleKey.D) movementDirection = Direction.Right;
                        else if (key == ConsoleKey.A) movementDirection = Direction.Left;
                    }
                }
            }
        }
    }

    class Coord
    {
        public int X { get; private set; }
        public int Y { get; private set; }
        
        public Coord(int x, int y)
        {
            X = x;
            Y = y;
        }

        public override bool Equals(object? obj)
        {
            if (obj == null || GetType() != obj.GetType()) return false;
            Coord other = (Coord)obj;
            return X == other.X && Y == other.Y;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(X, Y);
        }

        public void ApplyMovementDirection(Direction direction)
        {
            if (direction == Direction.Left) X--;
            else if (direction == Direction.Right) X++;
            else if (direction == Direction.Up) Y--;
            else if (direction == Direction.Down) Y++;
        }
    }

    enum Direction
    {
        Up,
        Down,
        Left,
        Right
    }
}
