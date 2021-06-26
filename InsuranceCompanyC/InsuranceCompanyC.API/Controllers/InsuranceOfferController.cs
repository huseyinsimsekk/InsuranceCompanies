using InsuranceCompanyC.API.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InsuranceCompanyC.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class InsuranceOfferController : ControllerBase
    {
        [HttpGet]
        public OfferModel Get([FromBody] CarInsuranceModel model)
        {
            if (model is null) throw new ArgumentNullException("Request is not valid.");
            var vmodel = new OfferModel()
            {
                Name = "Axa Sigorta",
                OfferDescription = "This is new offer",
                LogoUrl = "http://cdnsnet.mncdn.com/static/images/shared/firmLogos/axa.png",
                Fee = new Random().Next(600, 3000),
                LicencePlate = model.LicencePlate
            };
            return vmodel;
        }
    }
}
