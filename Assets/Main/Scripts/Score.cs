// score.cs

using System;

namespace MyApp
{
    public class Score
    {
        // Properties
        public string PlayerName { get; set; }
        public int Points { get; private set; }

        // Constructor
        public Score(string playerName)
        {
            PlayerName = playerName;
            Points = 0;
        }

        // Add points
        public void AddPoints(int value)
        {
            if (value < 0)
            {
                Console.WriteLine("Cannot add negative points.");
                return;
            }

            Points += value;
            Console.WriteLine($"{value} points added. Total: {Points}");
        }

        // Subtract points
        public void SubtractPoints(int value)
        {
            if (value < 0)
            {
                Console.WriteLine("Cannot subtract negative points.");
                return;
            }

            Points = Math.Max(0, Points - value);
            Console.WriteLine($"{value} points subtracted. Total: {Points}");
        }

        // Display score
        public void Display()
        {
            Console.WriteLine($"Player: {PlayerName}, Score: {Points}");
        }
    }
}
