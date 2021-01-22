using NUnit.Framework;
using Classes;

namespace Tests
{
    [TestFixture]
    public class TeamTests
    {
        [Test]
        public void Team_Constructor()
        {
            // Arrange
            string name = "Manchester United";
            int score = 1;

            // Act
            Team team1 = new Team(name, score);

            // Assert
            Assert.AreEqual(team1.Name, name);
            Assert.AreEqual(team1.Score, score);
        }

    }
}