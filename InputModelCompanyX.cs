using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace OfferApi
{
    public class CompanyXOfferRequest
    {
       
               
        public string Destination { get; set; }
        
        public List<Package> Packages { get; set; }
        public string Source { get; set; }
    }
    public class Package
    {
        public int Height { get; set; }
        public int Width { get; set; }
    }
}
