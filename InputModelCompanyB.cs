using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OfferApi
{
    public class InputModelCompanyB
    {
        public string Consignee { get; set; }

        public string Consignor { get; set; }

        public IEnumerable<Dimension> Cartons { get; set; }
    }
}
