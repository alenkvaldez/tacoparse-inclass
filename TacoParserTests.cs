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
        [InlineData("31.570771, -84.10353, Taco Bell Albany...",-84.10353)]
        [InlineData("34.280205, -86.217115, Taco Bell Albertvill...", -86.217115)]
        [InlineData("34.795116, -86.97191, 	Taco Bell Athens...", -86.97191)]



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
            var actual = tacoParserInt.Parse(line);

            //Assert
            Assert.Equal(expected, actual.Location.Latitude);
        }


        //TODO: Create a test ShouldParseLatitude
        [InlineData("34.073638, -84.677017, Taco Bell Acwort...", 34.073638,)]
        public void ShouldParseLatitude(string line, double expected)
        {
            //arrange
            var tacoParser = newTacoParser();
            //Act
            var actual = tacoParser.Parse(line);
            //Assert
            Assert.Equal(expected, actual.Location.Latitude);
        }


    }
}
