namespace LoggingKata
{
    /// <summary>
    /// Parses a POI file to locate all the Taco Bells
    /// </summary>
    public class TacoParser
    {
        readonly ILog logger = new TacoLogger();
        
        public ITrackable Parse(string line)
        {
            logger.LogInfo("Begin parsing"); //logging information

            // Take your line and use line.Split(',') to split it up into an array of strings, separated by the char ','
            var cells = line.Split(','); //takes commas and puts into an array

            // If your array.Length is less than 3, something went wrong
            if (cells.Length < 3)
            {
                logger.LogWarning("Less than 3 items. incomp data");

                // Log that and return null
                return null; // TODO Implement
            }


            // grab the latitude from your array at index 0 
            var lat = double.Parse(cells[0]);

            // grab the longitude from your array at index 1
            var longitude = double.Parse(cells[1]);

            // grab the name from your array at index 2
            var name = cells[2];
            // store taco bell name as string in var name

            // Your going to need to parse your string as a `double`
            // which is similar to parsing a string as an `int` - DONEX2


            // You'll need to create a TacoBell class
            // that conforms to ITrackable - DONEX2

            // Then, you'll need an instance of the TacoBell class
            // With the name and point set correctly
            // set values inside taco bell IT; stores var name = cells[2];
            // store new instance of point to store lat and long
            var point = new Point();
            point.Latitude = lat;
            point.Longitude = longitude;

            // ^^ store into below
            var tacoBell = new TacoBell();
            tacoBell.Name = name;
            tacoBell.Location = point; //stores long and lat


            // Then, return the instance of your TacoBell class
            // Since it conforms to ITrackable


            return null;
        }
    }
}