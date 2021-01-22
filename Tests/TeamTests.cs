using Classes;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Tests
{
    public class TeamTests
    {
        [NUnit.Framework.Test]
        public void Match_Constructor()
        {
            // Arrange
            string name = "Manchester United";
            int score = 1;

            // Act
            Team team1 = Team(name, score);

            // Assert
            Assert.AreEqual(match1.Name, name)
            Assert.AreEqual(match1.Score, score)
    }
    }
}
