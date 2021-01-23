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
            List<Match> matches = new List<Match>();

            // Act
            ScoreBoard scoreBoard = new ScoreBoard();

            // Assert
            Assert.AreEqual(scoreBoard.Matches, matches);
        }
    }
}
