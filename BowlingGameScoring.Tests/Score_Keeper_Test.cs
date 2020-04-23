using System;
using Xunit;

namespace BowlingGameScoring.Tests
{
    public class Score_Keeper_Test
    {
        //GIVEN 
        //WHEN
        //THEN
        [Fact]
        public void frame_1_attempt1_score_results_in_8()
        {
            // Tests that on a single bowl where 8 pins knocked down will return a score of 8.
            //Arrange
            var previousFrameScore = 0;
            var pinsKnockedDownFirstAttempt = 8;
            var pinsKnockedDownSecondAttempt = 0;
            var expectedResult = 8;
            var bowler = new Bowler();
            //Act
            var actualResult = bowler.Bowl(previousFrameScore, pinsKnockedDownFirstAttempt, pinsKnockedDownSecondAttempt);
            //Asserts
            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void frame_1_attempts2_score_results_in_10()
        {
            // Tests that on a two attemps where 5 pins knocked down on attempt 1 and 5 pins knocked down attempt 2 will return a score of 10.
            //Arrange
            var previousFrameScore = 0;
            var pinsKnockedDownAttempt1 = 5;
            var pinsKnockedDownAttempt2 = 5;
            var expectedResult = 10;
            var bowler = new Bowler();
            //Act
            var actualResult = bowler.Bowl(previousFrameScore, pinsKnockedDownAttempt1, pinsKnockedDownAttempt2);
            //Asserts
            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void frame_1_attempt1_0pins_attempt2_4pins_score_results_in_4()
        {
            // Tests that on a two attemps where 5 pins knocked down on attempt 1 and 5 pins knocked down attempt 2 will return a score of 10.
            //Arrange
            var previousFrameScore = 0;
            var pinsKnockedDownAttempt1 = 0;
            var pinsKnockedDownAttempt2 = 4;
            var expectedResult = 4;
            var bowler = new Bowler();
            //Act
            var actualResult = bowler.Bowl(previousFrameScore, pinsKnockedDownAttempt1, pinsKnockedDownAttempt2);
            //Asserts
            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void after_spare_total_score_increase_by_next_turn_score()
        {
            //Arrange
            var previousFrameScore = 10;
            var pinsKnockedDownAttempt1 = 2;
            var pinsKnockedDownAttempt2 = 4;
            var expectedResult = 8;
            var bowler = new Bowler();
            //Act
            var actualResult = bowler.Bowl(previousFrameScore, pinsKnockedDownAttempt1, pinsKnockedDownAttempt2);
            //Asserts
            Assert.Equal(expectedResult, actualResult);
        }
    }
}
