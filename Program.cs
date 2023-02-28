using System;
using System.Linq;
using System.IO;
using GeoCoordinatePortable;

namespace LoggingKata
{
    class Program
    {
        static readonly ILog logger = new TacoLogger();
        const string csvPath = "TacoBell-US-AL.csv";

        static void Main(string[] args)
        {
            // TODO:  Find the two Taco Bells that are the furthest from one another.
            // HINT:  You'll need two nested forloops ---------------------------

            logger.LogInfo("Log initialized");

            // use File.ReadAllLines(path) to grab all the lines from your csv file
            // Log and error if you get 0 lines and a warning if you get 1 line
            string[] lines = File.ReadAllLines(csvPath);
            if (lines.Length == 0)
            {
                logger.LogError("file has no input");
            }

            if (lines.Length == 1)
            {
                logger.LogWarning("file only has one line of input");
            }

            logger.LogInfo($"Lines: {lines[0]}");

            // Create a new instance of your TacoParser class
            var parser = new TacoParser();

            // Grab an IEnumerable of locations using the Select command: var locations = lines.Select(parser.Parse);
            var locations = lines.Select(line => parser.Parse(line)).ToArray();
            // for ea line in lines, we parse that line and turn into an array stored into
            // var locations; since parse returns itrackable, we will have collection
            // of tacobells

            // DON'T FORGET TO LOG YOUR STEPS

            // Now that your Parse method is completed, START BELOW ----------

            // TODO: Create two `ITrackable` variables with initial values of `null`.
            // These will be used to store your two taco bells that are the farthest from each other.
            // Create a `double` variable to store the distance

            ITrackable tacoBell1 = null; // acts as placeholders
            ITrackable tacoBell2 = null; // acts as placeholders
            double distance = 0;

            // Include the Geolocation toolbox, so you can compare locations: `using GeoCoordinatePortable;`

            //HINT NESTED LOOPS SECTION---------------------

            for (int i = 0; i < locations.Length; i++) // while i < locations, run loop and increment i
                                                       // whatever i is equal to will be "loca"
            {
                // Do a loop for your locations to grab each location as the origin (perhaps: `locA`)
                var locA = locations[i]; //i will increment from 0 to 237; represents current one we on

                // Create a new corA Coordinate with your locA's lat and long
                var corA = new GeoCoordinate();
                corA.Latitude = locA.Location.Latitude;
                corA.Longitude = locA.Location.Longitude; //used to compare to other locations

                // Now, do another loop on the locations with the scope of your first loop, so you can grab the "destination" location (perhaps: `locB`)
                for (int j = 0; j < locations.Length; j++) // for loop 
                {
                    // Create a new Coordinate with your locB's lat and long
                    // Now, compare the two using `.GetDistanceTo()`, which returns a double
                    var locB = locations[j];
                    var corB = new GeoCoordinate();
                    corB.Latitude = locB.Location.Latitude;
                    corB.Longitude = locB.Location.Longitude;


                    // If the distance is greater than the currently saved distance,
                    // update the distance and the two `ITrackable` variables you set above
                    if (corA.GetDistanceTo(corB) > distance) // checks if distance bw any 2 locations are greatest and updates
                    {
                        distance = corA.GetDistanceTo(corB);
                        tacoBell1 = locA;
                        tacoBell2 = locB;
                    }
                }
            }

            // Once you've looped through everything, you've found the two Taco Bells farthest away from each other.
            logger.LogInfo($"{tacoBell1.Name} and {tacoBell2.Name} are the farthest part");
           
          

            // Once you've looped through everything, you've found the two Taco Bells furthest away from each other.
        }


    }
    }
}
