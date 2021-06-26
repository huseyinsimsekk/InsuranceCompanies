using InsuranceCompanyB.API.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InsuranceCompanyB.API.Controllers
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
                Name = "Allianz",
                OfferDescription = "This is new offer",
                LogoUrl = "http://cdnsnet.mncdn.com/static/images/shared/firmLogos/allianz.png",
                Fee = new Random().Next(400, 5000),
                LicencePlate = model.LicencePlate
            };
            return vmodel;
        }
    }
}
