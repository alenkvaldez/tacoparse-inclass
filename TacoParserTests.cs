using System;
using Xunit;

namespace LoggingKata.Test
{
    public class TacoParserTests
    {
        [Fact]
        public void ShouldDoSomething()
        {
            // TODO: Complete Something, if anything

            //Arrange code we need to call method we testing - make object which is -
            var tacoParser = new TacoParser(); //tacoparser instance helps create new instance of taco parser class

            //Act - use name of instance, use line as argument 
            var actual = tacoParser.Parse("34.073638, -84.677017, Taco Bell Acwort...");

            //Assert - compare
            Assert.NotNull(actual.Location.Longitude);

        }

        [Theory]
        [InlineData("34.073638, -84.677017, Taco Bell Acwort...", -84.677017)]
        public void ShouldParseLongitude(string line, double expected)
        {
            // TODO: Complete - "line" represents input data we will Parse to
            //       extract the Longitude.  Your .csv file will have many of these lines,
            //       each representing a TacoBell location

            //Arrange
            var tacoParserInst = new TacoParserTests();
            // write code we need in order to call method we testing
            // contains tacoparser methods
            // parse method in tacoparser will take locations in file and turn into string


            //Act
            var actual = tacoParserInst.Parse(line);

            //Assert
            Assert.Equal(expected, actual.Location.Latitude);
        }


        //TODO: Create a test ShouldParseLatitude

    }
}
