using System;
using System.Collections.Generic;
using System.Text;

namespace BowlingGameScoring
{
    public class Bowler
    {
        public string Name { get; set; }
        public int Score { get; set; }
        public int CurrentFrame { get; set; }
        public int FrameScore { get; set; }
        public int FrameAttempt { get; set; }
        
        public Bowler()
        {
            Name = "Jane Doe";
            Score = 0;
            CurrentFrame = 1;
            FrameScore = 0;
            FrameAttempt = 1;
        }
        
        public int Bowl(int pinsDownFirstAttempt, int pinsDownSecondAttempt)
        {
            var firstTry = Attempt(pinsDownFirstAttempt);
            var secondTry = 0;
            if (firstTry != 10)
            {
                secondTry = Attempt(pinsDownSecondAttempt);
            }
            FrameScore = firstTry + secondTry;
            Score += FrameScore;
            return Score;
        }

        public int Attempt(int pinsKnockedDown)
        {
            //Random randomNum = new Random();
            //var pinsKnockedDown = randomNum.Next(1, 11);
            
            return pinsKnockedDown;
        }
    }
}
