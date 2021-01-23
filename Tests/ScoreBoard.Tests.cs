using Classes;
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
            ScoreBoard scoreBoard = new ScoreBoard();
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
            Match match1 = new Match(homeTeam, awayTeam);
            ScoreBoard scoreBoard = new ScoreBoard();

            // Act
            scoreBoard.StartMatch(match1);

            // Assert
            Assert.AreEqual(scoreBoard.Matches[0], match1);
        }

        [Test]
        public void ScoreBoard_ProcessInput()
        {
            // Arrange
            Team homeTeam = new Team("Real Madrid", 1);
            Team awayTeam = new Team("Barcelona", 1);
            Match match1 = new Match(homeTeam, awayTeam);
            List<Match> matches = new List<Match>();
            matches.Add(match1);
            ScoreBoard scoreBoard = new ScoreBoard();

            // Act
            scoreBoard.ProcessInput(0);

            // Assert
            Assert.AreEqual(scoreBoard.Matches, matches);
        }
    }
}
