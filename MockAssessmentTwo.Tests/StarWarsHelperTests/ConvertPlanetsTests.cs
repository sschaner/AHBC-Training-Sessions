using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using System.Linq;

namespace MockAssessmentTwo.Tests.StarWarsHelperTests
{
    public class ConvertPlanetsTests
    {
        // Happy path
        [Fact]
        public void ArrayOfStringsGiven_ListInReverseIsReturned()
        {
            // Arrange
            StarWarsHelper subject = new StarWarsHelper();
            string[] planets = new string[] { "Alderon", "Degobah", "Tatooine", "Naboo" };

            // Act
            List<string> planetList = subject.ConvertPlanets(planets);

            // Assert
            Assert.Equal("Naboo", planetList[0]);
        }

        // Sad path
        [Fact]
        public void ArrayElementIsNull_ThrowsArgumentNullException()
        {
            // Arrange
            StarWarsHelper subject = new StarWarsHelper();
            string[] planets = new string[1];

            // Act
            Action action = () => subject.ConvertPlanets(planets);

            // Assert
            Assert.Throws<ArgumentNullException>(action);
        }
    }
}
