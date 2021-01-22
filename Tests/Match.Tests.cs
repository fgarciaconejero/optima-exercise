using Classes;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Tests
{
    [TestFixture]
    class MatchTests
    {
        [Test]
        public void Match_Constructor()
        {
            // Arrange
            Team homeTeam = new Team("Real Madrid", 1);
            Team awayTeam = new Team("Barcelona", 1);

            // Act
            Match match1 = new Match(homeTeam, awayTeam);

            // Assert
            Assert.AreEqual(match1.HomeTeam, homeTeam);
            Assert.AreEqual(match1.AwayTeam, awayTeam);
        }

        [Test]
        public void Match_Start()
        {
            // Arrange
            Team homeTeam = new Team("Real Madrid", 1);
            Team awayTeam = new Team("Barcelona", 1);
            Match match1 = new Match();

            // Act
            match1.StartMatch(homeTeam, awayTeam);

            // Assert
            Assert.AreEqual(match1.HomeTeam, homeTeam);
            Assert.AreEqual(match1.AwayTeam, awayTeam);
        }
    }
}
