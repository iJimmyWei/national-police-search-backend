using System;

namespace Police.Model
{
    public class StreetCrimeResponse
    {
        public string Id { get; set; }

        public double? Lat { get; set; }

        public double? Long { get; set; }

        public int Count { get; set; }
    }
}
