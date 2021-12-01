using System;
using System.Collections;
using System.Collections.Generic;

namespace OfferApi
{
    public class InputModelCompanyA
    {
        public string ContactAddress { get; set; }

        public string WareHouseAddress { get; set; }

        public IEnumerable<Dimension> Dimensions { get; set; }

        
    }
    public class Dimension
    {
        public int Height { get; set; }
        public int Width { get; set; }
    }
}
