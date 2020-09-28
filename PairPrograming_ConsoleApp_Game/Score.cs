using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PairPrograming_ConsoleApp_Game
{
    public class Score
    {
        public int GameScore { get; set; }

        public Score() 
        {
            GameScore = 20;
        } 


        public int GetScore()
        {
            return GameScore;
        }

        public void CorrectAnswer()
        {
            GameScore += 10;
        }

        public void IncorrectAnswer()
        {
            GameScore -= 10;
        }

        public void PrintScore()
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            if (GameScore < 0)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
            }
            Console.WriteLine($"You'r Score: {GameScore}");
            Console.ResetColor();
        }
    }
}
