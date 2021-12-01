using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OfferApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompanyBController : ControllerBase
    {
        [HttpPost]
        [Route("ProductOffer")]
        public async Task<ActionResult<OfferResponse>> GetProductOffer([FromBody] InputModelCompanyB input)
        {
            var response = new OfferResponse() { Price = 10 };
            return Ok(response);
        }
    }
}
