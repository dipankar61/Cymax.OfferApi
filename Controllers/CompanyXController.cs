using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace OfferApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompanyXController : ControllerBase
    {
        [HttpPost]
        [Route("ProductOffer")]
        public async Task<ActionResult<OfferResponse>> ProductOffer(CompanyXOfferRequest input)
        {


            var response = new OfferResponse() { Price = 7 };
            return Ok(response);

        }
    }
}
