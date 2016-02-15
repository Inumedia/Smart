using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Smart.Services.Geo
{
    /// <summary>
    /// Geonames translation services for translating zip codes to long/lat coords.
    /// </summary>
    /// <see cref="http://download.geonames.org/export/zip/US.zip"/>
    public class GeonamesTranslation : IGeoTranslate
    {
        public GeonamesTranslation()
        {
            string dataPath = Path.Combine(Directory.GetCurrentDirectory(), "..", "Data", "US", "US.txt");
            using(StreamReader reader = new StreamReader(File.OpenRead(dataPath)))
            {
                string line = null;
                ZipEntries = new List<ZipCodeEntry>();
                while ((line = reader.ReadLine()) != null)
                    ZipEntries.Add(new ZipCodeEntry(line));
            }
        }

        private List<ZipCodeEntry> ZipEntries { get; set; }

        public Tuple<float, float> GetLatLong(int zipCode)
        {
            return ZipEntries
                .Where(c => c.PostalCode == zipCode.ToString())
                .Select(c => new Tuple<float, float>(c.Lat, c.Long))
                .First();
        }

        class ZipCodeEntry
        {
            public string CountryCode, PostalCode, PlaceName, State, StateAbrv, Province, SubProvince, Community, SubCommunity;
            public float Lat, Long;
            public ZipCodeEntry(string line)
            {
                string[] values = line.Trim('\r', '\n', ' ').Split('\t');
                int i = 0;
                CountryCode = values[i++];
                PostalCode = values[i++];
                PlaceName = values[i++];
                State = values[i++];
                StateAbrv = values[i++];
                Province = values[i++];
                SubProvince = values[i++];
                Community = values[i++];
                SubCommunity = values[i++];
                Lat = float.Parse(values[i++]);
                Long = float.Parse(values[i++]);
            }
        }
    }
}
