using Classes;
using Interfaces;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Tests
{
    [TestFixture]
    class ScoreBoardTests
    {
        [Test]
        public void ScoreBoard_Constructor()
        {
            // Arrange

            // Act
            ScoreBoard scoreBoard = new ScoreBoard(new ConsoleHandler());
            List<Match> matches = new List<Match>();

            // Assert
            Assert.AreEqual(scoreBoard.Matches, matches);
        }

        [Test]
        public void ScoreBoard_Start()
        {
            // Arrange
            Team homeTeam = new Team("Real Madrid", 1);
            Team awayTeam = new Team("Barcelona", 1);
            Match match1 = new Match(homeTeam, awayTeam, 0);
            ScoreBoard scoreBoard = new ScoreBoard(new ConsoleHandler());

            // Act
            scoreBoard.StartMatch(match1);

            // Assert
            Assert.AreEqual(scoreBoard.Matches[0], match1);
        }

        [Test]
        public void ScoreBoard_ProcessInput_Input_Is_1()
        {
            // Arrange
            Team homeTeam = new Team("Manchester United", 1);
            Team awayTeam = new Team("Manchester United", 1);
            Match match1 = new Match(homeTeam, awayTeam, 0);
            List<Match> matches = new List<Match>
            {
                match1
            };
            ScoreBoard scoreBoard = new ScoreBoard(new ConsoleHandler_Mock());
         

            // Act
            scoreBoard.ProcessInput(1);

            // Assert
            Assert.AreEqual(scoreBoard.Matches[0].AwayTeam.Name, matches[0].AwayTeam.Name);
            Assert.AreEqual(scoreBoard.Matches[0].HomeTeam.Name, matches[0].HomeTeam.Name);
            Assert.AreEqual(scoreBoard.Matches[0].AwayTeam.Score, matches[0].AwayTeam.Score);
            Assert.AreEqual(scoreBoard.Matches[0].HomeTeam.Score, matches[0].HomeTeam.Score);
        }

        [Test]
        public void ScoreBoard_GetSummary()
        {
            // Arrange
            ScoreBoard scoreBoard = new ScoreBoard(new ConsoleHandler_Mock());

            Team homeTeam = new Team("Mexico", 0);
            Team awayTeam = new Team("Canada", 5);
            Match match = new Match(homeTeam, awayTeam, 0);
            scoreBoard.StartMatch(match);


            homeTeam = new Team("Spain", 10);
            awayTeam = new Team("Brazil", 2);
            match = new Match(homeTeam, awayTeam, 1);
            scoreBoard.StartMatch(match);


            homeTeam = new Team("Germany", 2);
            awayTeam = new Team("France", 2);
            match = new Match(homeTeam, awayTeam, 2);
            scoreBoard.StartMatch(match);


            homeTeam = new Team("Uruguay", 6);
            awayTeam = new Team("Italy", 6);
            match = new Match(homeTeam, awayTeam, 3);
            scoreBoard.StartMatch(match);

            homeTeam = new Team("Argentina", 3);
            awayTeam = new Team("Australia", 1);
            match = new Match(homeTeam, awayTeam, 4);
            scoreBoard.StartMatch(match);
            
            string summary = "Match ID: 3 - Uruguay 6 vs Italy 6\n";
            summary += "Match ID: 1 - Spain 10 vs Brazil 2\n";
            summary += "Match ID: 0 - Mexico 0 vs Canada 5\n";
            summary += "Match ID: 4 - Argentina 3 vs Australia 1\n";
            summary += "Match ID: 2 - Germany 2 vs France 2\n";

            // Act
            string summaryResult = scoreBoard.GetSummary();

            // Assert
            Assert.AreEqual(summary, summaryResult);
        }

        [Test]
        public void ScoreBoard_FinishMatch()
        {
            // Arrange
            ScoreBoard scoreBoard = new ScoreBoard(new ConsoleHandler_Mock());

            Team homeTeam = new Team("Manchester United", 1);
            Team awayTeam = new Team("Real Madrid", 3);
            Match match1 = new Match(homeTeam, awayTeam, 0);
            scoreBoard.StartMatch(match1);
            scoreBoard.StartMatch(match1);


            List<Match> matches = new List<Match>
            {
                match1,
                match1
            };

            // Act
            scoreBoard.FinishMatch(0);

            // Assert
            Assert.AreNotEqual(matches.Count, scoreBoard.Matches.Count);
        }

        [Test]
        public void ScoreBoard_UpdateScore()
        {
            // Arrange
            ScoreBoard scoreBoard = new ScoreBoard(new ConsoleHandler_Mock());

            Team homeTeam = new Team("Manchester United", 1);
            Team awayTeam = new Team("Real Madrid", 3);
            Match match1 = new Match(homeTeam, awayTeam, 0);
            scoreBoard.StartMatch(match1);
            scoreBoard.StartMatch(match1);

            // Act
            scoreBoard.UpdateScore(1, 2, 4);

            // Assert
            Assert.AreEqual(scoreBoard.Matches[0].HomeTeam.Score, 2);
            Assert.AreEqual(scoreBoard.Matches[0].AwayTeam.Score, 4);
        }

        public class ConsoleHandler_Mock : IConsoleHandler
        {
            public string ReadString()
            {
                return "Manchester United";
            }
            public int ReadInt(bool format)
            {
                return 1;
            }
        }
    }
}
