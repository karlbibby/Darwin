using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Darwin.Objects
{
    public class SearchResultCollection
    {
        public int SpeciesId { get; set; }
        public string Name { get; set; }
        public string Order { get; set; }
        public string Family { get; set; }
        public int Flag { get; set; }
        public int? Colour { get; set; }
    }
}
