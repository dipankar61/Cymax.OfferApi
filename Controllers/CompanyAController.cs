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
    public class CompanyAController : ControllerBase
    {
        [Route("ProductOffer")]
        [HttpPost]
        
        public async Task<ActionResult<OfferResponse>> GetProductOffer([FromBody] InputModelCompanyA input)
        {
            var response = new OfferResponse() { Price = 5 };
            return Ok(response);
        }
    }
}
