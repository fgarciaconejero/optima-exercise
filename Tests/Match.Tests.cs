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
            Match match1 = new Match(homeTeam, awayTeam, 0);

            // Assert
            Assert.AreEqual(match1.HomeTeam, homeTeam);
            Assert.AreEqual(match1.AwayTeam, awayTeam);
        }
    }
}
