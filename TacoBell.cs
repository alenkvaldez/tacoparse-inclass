using System;
namespace LoggingKata
{
	public class TacoBell : ITrackable
	{
		public TacoBell()
		{
		}
		//need to put name property and location property from IT to conform to IT
        public string Name { get; set; }
        public Point Location { get; set; }
    }
}

